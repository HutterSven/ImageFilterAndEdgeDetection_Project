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
        private IAccessData accessData = new AccessData();
        Image filteredImage;
        Image edgeDetectedImage;
        Image originalImage;

        public MainForm()
        {
            InitializeComponent();
            tabControl1.Selected += new TabControlEventHandler(TabControl1_SelectedIndexChanged);
            originalImage = Resources.OriginalImage;
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


        /// <summary>
        /// apply filters according to the checked filters
        /// </summary>
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
                pictureBox1.Image = new Bitmap(originalImage);
            }
            else
            {
                Bitmap newBitmap = new Bitmap(originalImage);
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

        private void button1_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        /// <summary>
        /// save given image to given path
        /// </summary>
        /// <param name="imageToSave"></param>
        /// <param name="path"></param>
        private void saveImage()
        {
            if (pictureBox1.Image != null)
            {
                String path = null;
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Title = "Specify a file name and file path.",
                    Filter = "Png Images(.png)|.png"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;
                }
                Bitmap imageToSave = new Bitmap(pictureBox1.Image);
                accessData.SaveImage(imageToSave, path);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadImage();
        }

        /// <summary>
        /// load an image through the given path
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Bitmap</returns>
        private void loadImage()
        {
            String imagePath = null;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Select an image file.",
                Filter = "PNG files|.png"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
            }
            Bitmap loadedImage = accessData.LoadImage(imagePath);
            if(loadedImage != null)
            {
                pictureBox1.Image = loadedImage;
            }
            originalImage = pictureBox1.Image;
            BaWBox.Checked = false;
            rainbowBox.Checked = false;
            colorSwapBox.Checked = false;
        }
    }
}
