using System.Drawing;

namespace ImageFilterAndEdgeDetection_Project
{
    public interface IEdgeDetection
    {
        /// <summary>
        /// fetches and returns the Matrix based on the filter parameter
        /// </summary>
        /// <param name="filter">Name of the Matrix</param>
        /// <returns>Filter Matrix</returns>
        double[,] chooseFilter(string filter);
        /// <summary>
        /// Detects the edges of the bitmap based on the horizontal and vertical filters
        /// </summary>
        /// <param name="oldBmp">input bitmap</param>
        /// <param name="xfilter">horizontal filter</param>
        /// <param name="yfilter">vertical filter</param>
        /// <returns>the new Bitmap</returns>
        Bitmap filter(Bitmap oldBmp, string xfilter, string yfilter);
    }
}