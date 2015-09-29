using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace GISDesign
{
    public partial class GuassianFrm : Form
    {
        public GuassianFrm()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Picturebox1_Paint);

        }

        private Bitmap tiffmap;
        private string FileName;


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";//初始显示目录

            //下次打开对话框是否定位到上次打开的目录
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|PNG files (*.png)|*.png|TIFF files (*.tif)|*tif|JPEG files (*.jpg)|*.jpg |All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 5;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //将选择的文件赋给文本框
                textBox1.Text = openFileDialog1.FileName;
                FileName = openFileDialog1.FileName;
                try
                {
                    tiffmap = (Bitmap)Image.FromFile(FileName);
                   

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            Invalidate();
        }


        private void GuassianFrm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime();
            DateTime dt2 = new DateTime();
            TimeSpan dt3 = new TimeSpan();
            dt1 = DateTime.Now;
            pg1.Value = 0;

            if (tiffmap != null)
            {
                //实例化gauss

                int width = tiffmap.Width;
                int height = tiffmap.Height;
                int WidHeig = tiffmap.Width * tiffmap.Height;




                Rectangle rect = new Rectangle(0, 0, width, height);

                BitmapData bmpData = tiffmap.LockBits(rect, ImageLockMode.ReadWrite, tiffmap.PixelFormat);
                IntPtr ptr = bmpData.Scan0;

                int bytes = bmpData.Stride * bmpData.Height;
                byte[] grayValues = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, grayValues, 0, bytes);
                double[] tempArray;
                double[] tempImage = new double[bytes];
                //得到均方差
                double sigma = Convert.ToDouble(textBox3.Text);
                for (int a = 0; a < bytes; a++)
                {
                    tempImage[a] = Convert.ToDouble(grayValues[a]);
                }
                pg1.Value = 10;
                //调用高斯滤波方法
                gaussSmooth(tempImage, out tempArray, sigma, bmpData.Stride, bmpData.Height);
                //gaussSmooth(tempImage, out tempArray, sigma);
                for (int b = 0; b < bytes; b++)
                {
                    if (tempArray[b] > 255)
                    {
                        grayValues[b] = 255;
                    }
                    else if (tempArray[b] < 0)
                    {
                        grayValues[b] = 0;
                    }
                    else
                    {
                        grayValues[b] = Convert.ToByte(tempArray[b]);
                    }
                }
               

                System.Runtime.InteropServices.Marshal.Copy(grayValues, 0, ptr, bytes);
                tiffmap.UnlockBits(bmpData);



                /*   MemoryStream ms = new MemoryStream();
                    ms = new System.IO.MemoryStream(tempArray));
                    tiffmap = (Bitmap)System.Drawing.Image.FromStream(ms);

                    tiffmap.Save("c:\\test.tiff",System.Drawing.Imaging.ImageFormat.Tiff);
                    */
            }
            Invalidate();
            dt2 = DateTime.Now;
            dt3 = dt2 - dt1;
            time.Text = dt3.ToString();
            pg1.Value = 100;




        }


        private void gaussSmooth(double[] inputImage, out double[] outputImage, double sigma, int Width, int Height)
        {
            //方差
            double std2 = 2 * sigma * sigma;
            //半径=3σ
            int radius = Convert.ToInt16(Math.Ceiling(3 * sigma));
            int filterWidth = 2 * radius + 1;
            double[] filter = new double[filterWidth];
            outputImage = new double[inputImage.Length];
            //限定输入的图像为方阵的情况下得到图像的宽度或高度
            //  int length = Convert.ToInt16(Math.Sqrt(inputImage.Length));
            double[,] tempImage1 = new double[Height, Width];
            double[,] tempImage2 = new double[Height, Width];
            double sum = 0;
            //产生一维高斯函数
            for (int i = 0; i < filterWidth; i++)
            {
                int xx = (i - radius) * (i - radius);
                filter[i] = Math.Exp(-xx / std2);
                sum += filter[i];
            }
            //归一化
            for (int i = 0; i < filterWidth; i++)
            {
                filter[i] = filter[i] / sum;
            }
            //水平方向滤波
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    double temp = 0;
                    for (int k = -radius; k <= radius; k++)
                    {
                        //循环延拓
                        int rem = (Math.Abs(j + k)) % Width;
                        //计算卷积和
                        temp += inputImage[i * Width + rem] * filter[k + radius];
                    }
                    tempImage1[i, j] = temp;
                }
            }
            //垂直方向滤波
            for (int j = 0; j < Width; j++)
            {
                for (int i = 0; i < Height; i++)
                {
                    double temp = 0;
                    for (int k = -radius; k <= radius; k++)
                    {
                        //循环延拓
                        int rem = (Math.Abs(i + k)) % Height;
                        //计算卷积和
                        temp += tempImage1[rem, j] * filter[k + radius];
                    }
                    tempImage2[i, j] = temp;
                }
                //将卷积好的二维数组再复制给一维数组outputImage
                for (int d = 0; d < Height; d++)//循环遍历垂直方向像素
                {
                    for (int k = 0; k < Width; k++)//循环遍历长方形图案水平方向像素
                    {
                        outputImage[d * Width + k] = tempImage2[d, k];
                    }
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (tiffmap == null)
            {
                return;
            }
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save as";
            saveDialog.OverwritePrompt = true;
            saveDialog.Filter = "ALL(*.*)|*.*|" + "TIFF文件(.tif)|*.tif"; ;
            saveDialog.ShowHelp = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {


                string fileName = saveDialog.FileName;
                tiffmap.Save(fileName, ImageFormat.Tiff);


            }
        }



        private void Picturebox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (tiffmap != null)
            {
                g.DrawImage(tiffmap, 0,20, tiffmap.Width, tiffmap.Height);
            }
        }
    }
}



     

     

