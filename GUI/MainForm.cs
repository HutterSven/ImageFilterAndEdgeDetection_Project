using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFilterAndEdgeDetection_Project
{
    public partial class MainForm : Form
    {
        bool noneChecked = true;
        private IEdgeDetection edgeDetection = new EdgeDetection();
        private IImageFilters imageFilters = new ImageFilters();
        Image filteredImage;
        Image edgeDetectedImage;

        public MainForm()
        {
            InitializeComponent();
            tabControl1.Selected += new TabControlEventHandler(TabControl1_SelectedIndexChanged);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Resources.OriginalImage);
        }

        private void rainbowBox_CheckedChanged(object sender, EventArgs e)
        {
            stateChanged();
        }

        private void BaWBox_CheckedChanged(object sender, EventArgs e)
        {
            stateChanged();
        }

        private void colorSwapBox_CheckedChanged(object sender, EventArgs e)
        {
            stateChanged();
        }

        public void stateChanged()
        {
            if(rainbowBox.Checked || BaWBox.Checked || colorSwapBox.Checked)
            {
                noneChecked = false;
            }
            else
            {
                noneChecked = true;
            }

            if (noneChecked)
            {
                pictureBox1.Image = new Bitmap(Resources.OriginalImage);
            }
            else
            {
                Bitmap newBitmap = new Bitmap(Resources.OriginalImage);
                if (rainbowBox.Checked)
                {
                    newBitmap = imageFilters.RainbowFilter(newBitmap);
                }
                if (BaWBox.Checked)
                {
                    newBitmap = imageFilters.BlackWhite(newBitmap);
                }
                if (colorSwapBox.Checked)
                {
                    newBitmap = imageFilters.ApplyFilterSwap(newBitmap);
                }
                pictureBox1.Image = newBitmap;
            }
        }

        private void prewittBtn_Click(object sender, EventArgs e)
        {
            edgeDetectedImage = edgeDetection.filter(new Bitmap(filteredImage), "Prewitt3x3Horizontal", "Prewitt3x3Vertical");
            pictureBox1.Image = edgeDetectedImage;
        }

        private void kirschBtn_Click(object sender, EventArgs e)
        {
            edgeDetectedImage = edgeDetection.filter(new Bitmap(filteredImage), "Kirsch3x3Horizontal", "Kirsch3x3Vertical");
            pictureBox1.Image = edgeDetectedImage;
        }

        private void sobelBtn_Click(object sender, EventArgs e)
        {
            edgeDetectedImage = edgeDetection.filter(new Bitmap(filteredImage), "Sobel3x3Horizontal", "Sobel3x3Vertical");
            pictureBox1.Image = edgeDetectedImage;
        }

        private void TabControl1_SelectedIndexChanged(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage2)
            {
                filteredImage = pictureBox1.Image;
            }

        }
    }
}
