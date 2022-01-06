using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilterAndEdgeDetection_Project
{
    class Matrixes
    {
        /// <summary>
        /// Prewitt3x3Horizontal Matrix
        /// </summary>
        public static double[,] Prewitt3x3Horizontal
        {
            get
            {
                return new double[,]
                { { -1,  0,  1, },
                  { -1,  0,  1, },
                  { -1,  0,  1, }, };
            }
        }

        /// <summary>
        /// Prewitt3x3Vertical Matrix
        /// </summary>
        public static double[,] Prewitt3x3Vertical
        {
            get
            {
                return new double[,]
                { {  1,  1,  1, },
                  {  0,  0,  0, },
                  { -1, -1, -1, }, };
            }
        }

        /// <summary>
        /// Kirsch3x3Horizontal Matrix
        /// </summary>
        public static double[,] Kirsch3x3Horizontal
        {
            get
            {
                return new double[,]
                { {  5,  5,  5, },
                  { -3,  0, -3, },
                  { -3, -3, -3, }, };
            }
        }

        /// <summary>
        /// Kirsch3x3Vertical Matrix
        /// </summary>
        public static double[,] Kirsch3x3Vertical
        {
            get
            {
                return new double[,]
                { {  5, -3, -3, },
                  {  5,  0, -3, },
                  {  5, -3, -3, }, };
            }
        }

        /// <summary>
        /// Sobel3x3Horizontal Matrix
        /// </summary>
        public static double[,] Sobel3x3Horizontal
        {
            get
            {
                return new double[,]
                { { -1,  0,  1, },
                  { -2,  0,  2, },
                  { -1,  0,  1, }, };
            }
        }

        /// <summary>
        /// Sobel3x3Vertical Matrix
        /// </summary>
        public static double[,] Sobel3x3Vertical
        {
            get
            {
                return new double[,]
                { {  1,  2,  1, },
                  {  0,  0,  0, },
                  { -1, -2, -1, }, };
            }
        }
    }
}
