using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace ImageFilterAndEdgeDetection_ProjectTest
{
    /// <summary>
    /// class containing comparators
    /// </summary>
    class Compare
    {
        /// <summary>
        /// comparing two given bitmaps pixel by pixel
        /// </summary>
        /// <param name="bitmap1"></param>
        /// <param name="bitmap2"></param>
        public static void CompareBitmap(Bitmap bitmap1, Bitmap bitmap2)
        {
            if(bitmap1.Size == bitmap2.Size)
            {
                for (int x = 0; x < bitmap1.Width; x++)
                {
                    for (int y = 0; y < bitmap1.Height; y++)
                    {
                        Assert.AreEqual(bitmap1.GetPixel(x, y), bitmap2.GetPixel(x, y));
                    }
                }
            }
        }
    }
}
