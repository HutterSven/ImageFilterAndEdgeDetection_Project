using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFilterAndEdgeDetection_Project
{
    public class DataAccessClass : IDataAccessClass
    {

        /// <summary>
        /// save given image to given path
        /// </summary>
        /// <param name="imageToSave"></param>
        /// <param name="path"></param>
        public void SaveImage(Bitmap imageToSave, string path)
        {
            if(imageToSave == null)
            {
                throw new ArgumentException("Image cannot be null", nameof(imageToSave));
            }
            else if (path == null || path == "")
            {
                throw new ArgumentException("Path cannot be null or empty string", nameof(path));
            }
            else
            {
                string fileExtension = Path.GetExtension(path).ToUpper();
                ImageFormat imgFormat = ImageFormat.Png;
                StreamWriter streamWriter = new StreamWriter(path, false);
                imageToSave.Save(streamWriter.BaseStream, imgFormat);
                streamWriter.Flush();
                streamWriter.Close();
            }
        }

        /// <summary>
        /// load an image through the given path
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Bitmap</returns>
        public Bitmap LoadImage(string path)
        {
            Bitmap loadedImage;
            try
            {
                StreamReader streamReader = new StreamReader(path);
                loadedImage = new Bitmap(streamReader.BaseStream);
            }
            catch (Exception)
            {
                loadedImage = null;
            }
            return loadedImage;
        }
    }
}
