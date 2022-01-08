using System;
using System.Drawing;

namespace ImageFilterAndEdgeDetection_Project
{
    class AccessData : IAccessData
    {
        IDataAccessClass dataAccess = new DataAccessClass();

        /// <summary>
        /// save given image to given path
        /// </summary>
        /// <param name="imageToSave"></param>
        /// <param name="path"></param>
        public void SaveImage(Bitmap imageToSave, String path)
        {
            dataAccess.SaveImage(imageToSave, path);
        }

        /// <summary>
        /// load an image through the given path
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Bitmap</returns>
        public Bitmap LoadImage(String path)
        {
            return dataAccess.LoadImage(path);
        }
    }
}
