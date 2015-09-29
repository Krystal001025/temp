using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CannyEdgeDetectionCSharp;
using System.Drawing.Imaging;

namespace MapControlApplication1
{
    public partial class CannyExatraction : Form
    {
        public CannyExatraction()
        {
            InitializeComponent();
        }
        Canny CannyData;





        private void OPEN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap files (*.bmp)|*.bmp|PNG files (*.png)|*.png|TIFF files (*.tif)|*tif|JPEG files (*.jpg)|*.jpg |All files (*.*)|*.*";
            ofd.FilterIndex = 5;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                try
                {
                    cannyPic.Image = Bitmap.FromFile(ofd.FileName);
                    cannyPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    cannyPicRe.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

     /**   private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
      * **/

        private void Canny_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime();
            DateTime dt2 = new DateTime();
            TimeSpan dt3 = new TimeSpan();
            float TH, TL;


            dt1 = DateTime.Now;
            pg1.Value = 0;
            TH = (float)Convert.ToDouble(TxtTH.Text);
            TL = (float)Convert.ToDouble(TxtTL.Text);

            pg1.Value = 10;



            CannyData = new Canny((Bitmap)cannyPic.Image, TH, TL);


            cannyPicRe.Image = CannyData.DisplayImage(CannyData.NonMax);



            cannyPicRe.Image = CannyData.DisplayImage(CannyData.GNL);

            cannyPicRe.Image = CannyData.DisplayImage(CannyData.GNH);

            cannyPicRe.Image = CannyData.DisplayImage(CannyData.EdgeMap);
            


            dt2 = DateTime.Now;
            dt3 = dt2 - dt1;
            time.Text = dt3.ToString();
            pg1.Value = 100;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            cannyPicRe.Image = null;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            {
                if (CannyData == null)
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
                    cannyPicRe.Image.Save(fileName, ImageFormat.Tiff);


                }
            }


        }

        private void CannyExatraction_Load(object sender, EventArgs e)
        {

        }

   
    }
}
