using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_TIFF_Document_Width_Height
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string TifFile = @"C:\image\Merge to TIF\Tif_Muilti_Page.tif";
        private void btnFindDimensions_Click(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream(TifFile, FileMode.Open, FileAccess.Read))
            {
                using (Image tif = Image.FromStream(stream, false, false))
                {
                    double width = tif.PhysicalDimension.Width;
                    double height = tif.PhysicalDimension.Height;
                    double hresolution = tif.HorizontalResolution;
                    double vresolution = tif.VerticalResolution;

                    lblSize.Text = "Width: " + width + " Height: " + height;
                }
            }
        }

        private void btnPages_Click(object sender, EventArgs e)
        {
            using (Image tifdoc = Image.FromFile(TifFile))
            {
                lblPages.Text = Convert.ToString(GetNumberOfPages(tifdoc));
            }
        }
        private int GetNumberOfPages(Image TiffImage)
        {
            return TiffImage.GetFrameCount(System.Drawing.Imaging.FrameDimension.Page);
        }
    }
}
