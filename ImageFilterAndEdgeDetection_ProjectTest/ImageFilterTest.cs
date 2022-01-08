using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using ImageFilterAndEdgeDetection_Project;
using NSubstitute;

namespace ImageFilterAndEdgeDetection_ProjectTest
{
    [TestClass]
    public class ImageFilterTest
    {
        private Bitmap original = Resource1.originalPenguins;
        private ImageFilters imageFilters = new ImageFilters();
        private IImageFilters iImageFilters = Substitute.For<IImageFilters>();

        [TestMethod]
        public void rainbowFilterTest()
        {
            Bitmap imageFiltered = Resource1.rainbowPenguins;
            iImageFilters.RainbowFilter(original).Returns(imageFiltered);
            Bitmap imageResult = imageFilters.RainbowFilter(original);
            Compare.CompareBitmap(iImageFilters.RainbowFilter(original), imageResult);
        }

        [TestMethod]
        public void blackAndWhiteFilterTest()
        {
            Bitmap imageFiltered = Resource1.blackAndWhitePenguins;
            iImageFilters.BlackWhite(original).Returns(imageFiltered);
            Bitmap imageResult = imageFilters.BlackWhite(original);
            Compare.CompareBitmap(iImageFilters.BlackWhite(original), imageResult);
        }

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
