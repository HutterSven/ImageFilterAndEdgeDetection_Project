using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterAndEdgeDetection_ProjectTest
{
    class Compare
    {
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
