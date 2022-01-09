using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageFilterAndEdgeDetection_Project
{
    public class EdgeDetection : IEdgeDetection
    {
        /// <summary>
        /// fetches and returns the Matrix based on the filter parameter
        /// </summary>
        /// <param name="filter">Name of the Matrix</param>
        /// <returns>Filter Matrix</returns>
        public double[,] chooseFilter(string filter)
        {
            switch (filter)
            {
                case "Prewitt3x3Horizontal":
                    return Matrixes.Prewitt3x3Horizontal;
                case "Prewitt3x3Vertical":
                    return Matrixes.Prewitt3x3Vertical;
                case "Kirsch3x3Horizontal":
                    return Matrixes.Kirsch3x3Horizontal;
                case "Kirsch3x3Vertical":
                    return Matrixes.Kirsch3x3Vertical;
                case "Sobel3x3Horizontal":
                    return Matrixes.Sobel3x3Horizontal;
                case "Sobel3x3Vertical":
                    return Matrixes.Sobel3x3Vertical;
                default:
                    return Matrixes.Prewitt3x3Horizontal;
            }
        }

        /// <summary>
        /// Detects the edges of the bitmap based on the horizontal and vertical filters
        /// </summary>
        /// <param name="oldBmp">input bitmap</param>
        /// <param name="xfilter">horizontal filter</param>
        /// <param name="yfilter">vertical filter</param>
        /// <returns>the new Bitmap</returns>
        public Bitmap filter(Bitmap oldBmp, string xfilter, string yfilter)
        {
            double[,] xFilterMatrix = chooseFilter(xfilter);
            double[,] yFilterMatrix = chooseFilter(yfilter);

            if (oldBmp != null)
            {
                BitmapData newbitmapData = new BitmapData();
                newbitmapData = oldBmp.LockBits(new Rectangle(0, 0, oldBmp.Width, oldBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);

                byte[] pixelbuff = new byte[newbitmapData.Stride * newbitmapData.Height];
                byte[] resultbuff = new byte[newbitmapData.Stride * newbitmapData.Height];

                Marshal.Copy(newbitmapData.Scan0, pixelbuff, 0, pixelbuff.Length);
                oldBmp.UnlockBits(newbitmapData);

                double blueX = 0.0;
                double greenX = 0.0;
                double redX = 0.0;

                double blueY = 0.0;
                double greenY = 0.0;
                double redY = 0.0;

                double blueTotal = 0.0;
                double greenTotal = 0.0;
                double redTotal = 0.0;

                int filterOffset = 1;
                int calcOffset = 0;

                int byteOffset = 0;

                for (int offsetY = filterOffset; offsetY <
                    oldBmp.Height - filterOffset; offsetY++)
                {
                    for (int offsetX = filterOffset; offsetX <
                        oldBmp.Width - filterOffset; offsetX++)
                    {
                        blueX = greenX = redX = 0;
                        blueY = greenY = redY = 0;

                        blueTotal = greenTotal = redTotal = 0.0;

                        byteOffset = offsetY *
                                     newbitmapData.Stride +
                                     offsetX * 4;

                        for (int filterY = -filterOffset;
                            filterY <= filterOffset; filterY++)
                        {
                            for (int filterX = -filterOffset;
                                filterX <= filterOffset; filterX++)
                            {
                                calcOffset = byteOffset +
                                             (filterX * 4) +
                                             (filterY * newbitmapData.Stride);

                                blueX += (double)(pixelbuff[calcOffset]) *
                                          xFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                greenX += (double)(pixelbuff[calcOffset + 1]) *
                                          xFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                redX += (double)(pixelbuff[calcOffset + 2]) *
                                          xFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                blueY += (double)(pixelbuff[calcOffset]) *
                                          yFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                greenY += (double)(pixelbuff[calcOffset + 1]) *
                                          yFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];

                                redY += (double)(pixelbuff[calcOffset + 2]) *
                                          yFilterMatrix[filterY + filterOffset,
                                                  filterX + filterOffset];
                            }
                        } 

                        blueTotal = 0;
                        greenTotal = Math.Sqrt((greenX * greenX) + (greenY * greenY));
                        redTotal = 0;

                        if (greenTotal > 255)
                        { greenTotal = 255; }

                        resultbuff[byteOffset] = (byte)(blueTotal);
                        resultbuff[byteOffset + 1] = (byte)(greenTotal);
                        resultbuff[byteOffset + 2] = (byte)(redTotal);
                        resultbuff[byteOffset + 3] = 255;
                    }
                }

                Bitmap resultbitmap = new Bitmap(oldBmp.Width, oldBmp.Height);

                BitmapData resultData = resultbitmap.LockBits(new Rectangle(0, 0,
                                         resultbitmap.Width, resultbitmap.Height),
                                                          ImageLockMode.WriteOnly,
                                                      PixelFormat.Format32bppArgb);

                Marshal.Copy(resultbuff, 0, resultData.Scan0, resultbuff.Length);
                resultbitmap.UnlockBits(resultData);
                return resultbitmap;
            }
            else
            {
                return null;
            }
        }
    }
}
