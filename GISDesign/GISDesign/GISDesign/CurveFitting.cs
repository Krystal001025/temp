using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapControlApplication1
{
    public partial class CurveFitting : Form
    {
        public CurveFitting()
        {
            InitializeComponent();
        }
        // open files
        private void FileOp_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap files (*.bmp)|*.bmp|PNG files (*.png)|*.png|TIFF files (*.tif)|*tif|JPEG files (*.jpg)|*.jpg |All files (*.*)|*.*";
            ofd.FilterIndex = 5;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileshowBox.Text = ofd.FileName;
                try
                {
                    Raster.Image = Bitmap.FromFile(ofd.FileName);
                    Raster.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        // curve fitting
        private void button1_Click(object sender, EventArgs e)
        {

            // create a matrix
            Bitmap map;
      
        }

        private void save_Click(object sender, EventArgs e)
        {
            {
               /** if (Raster.image == null)
                {
                    return;
                }*/
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "Save as";
                saveDialog.OverwritePrompt = true;
                saveDialog.Filter = "ALL(*.*)|*.*|" + "SHP Files(.shp)|*.shp"; ;
                saveDialog.ShowHelp = true;
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {


                    string fileName = saveDialog.FileName;
                 //   Raster.Image.Save(fileName,System.Drawing.Imaging.ImageFormat.S);
                    //how to save vector


                }
            }
        }
       

     
    }
}
