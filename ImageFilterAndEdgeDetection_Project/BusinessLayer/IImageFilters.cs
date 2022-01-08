using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterAndEdgeDetection_Project
{
    public interface IImageFilters
    {
        /// <summary>
        /// applies the rainbow filter on the given bitmap
        /// </summary>
        /// <param name="bmp">input bitmap</param>
        /// <returns>rainbow bitmap</returns>
        Bitmap RainbowFilter(Bitmap bmp);

        /// <summary>
        /// applies the black and white filter on a given bitmap
        /// </summary>
        /// <param name="Bmp">input bitmap</param>
        /// <returns>black and white bitmap</returns>
        Bitmap BlackWhite(Bitmap Bmp);

        /// <summary>
        /// Applies the color swap filter to the given bitmap
        /// </summary>
        /// <param name="bmp">input bitmap</param>
        /// <returns>color swapped bitmap</returns>
        Bitmap ApplyFilterSwap(Bitmap bmp);

    }
}
