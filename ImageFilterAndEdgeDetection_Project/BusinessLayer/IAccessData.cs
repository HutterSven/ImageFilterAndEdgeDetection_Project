using System.Drawing;

namespace ImageFilterAndEdgeDetection_Project
{
    public interface IAccessData
    {
        /// <summary>
        /// save given image to given path
        /// </summary>
        /// <param name="imageToSave"></param>
        /// <param name="path"></param>
        Bitmap LoadImage(string path);
        /// <summary>
        /// load an image through the given path
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Bitmap</returns>
        void SaveImage(Bitmap imageToSave, string path);
    }
}