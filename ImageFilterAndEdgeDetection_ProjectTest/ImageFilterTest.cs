using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using ImageFilterAndEdgeDetection_Project;
using NSubstitute;

namespace ImageFilterAndEdgeDetection_ProjectTest
{
    /// <summary>
    /// test class to test all the functions of the class ImageFilters
    /// </summary>
    [TestClass]
    public class ImageFilterTest
    {
        private Bitmap original = Resource1.originalPenguins;
        private ImageFilters imageFilters = new ImageFilters();
        private IImageFilters iImageFilters = Substitute.For<IImageFilters>();

        /// <summary>
        /// image filter test for the rainbow filter
        /// </summary>
        [TestMethod]
        public void rainbowFilterTest()
        {
            Bitmap imageFiltered = Resource1.rainbowPenguins;
            iImageFilters.RainbowFilter(original).Returns(imageFiltered);
            Bitmap imageResult = imageFilters.RainbowFilter(original);
            Compare.CompareBitmap(iImageFilters.RainbowFilter(original), imageResult);
        }

        /// <summary>
        /// image filter test for the black and white filter
        /// </summary>
        [TestMethod]
        public void blackAndWhiteFilterTest()
        {
            Bitmap imageFiltered = Resource1.blackAndWhitePenguins;
            iImageFilters.BlackWhite(original).Returns(imageFiltered);
            Bitmap imageResult = imageFilters.BlackWhite(original);
            Compare.CompareBitmap(iImageFilters.BlackWhite(original), imageResult);
        }

        /// <summary>
        /// image filter test for the color swap filter
        /// </summary>
        [TestMethod]
        public void colorSwapFilterTest()
        {
            Bitmap imageFiltered = Resource1.colorSwapPenguins;
            iImageFilters.ApplyFilterSwap(original).Returns(imageFiltered);
            Bitmap imageResult = imageFilters.ApplyFilterSwap(original);
            Compare.CompareBitmap(iImageFilters.ApplyFilterSwap(original), imageResult);
        }
    }
}
