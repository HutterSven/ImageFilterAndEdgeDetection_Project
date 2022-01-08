using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageFilterAndEdgeDetection_Project;
using System.Drawing;
using NSubstitute;

namespace ImageFilterAndEdgeDetection_ProjectTest
{
    [TestClass]
    public class EdgeDetectionTest
    {
        private Bitmap original = Resource1.originalPenguins;
        private EdgeDetection edgeDetection = new EdgeDetection();
        private IEdgeDetection iEdgeDetection = Substitute.For<IEdgeDetection>();

        [TestMethod]
        public void prewittMatrixTest()
        {
            Bitmap imageFiltered = Resource1.prewittPenguins;
            iEdgeDetection.filter(original, "Prewitt3x3Horizontal", "Prewitt3x3Vertical").Returns(imageFiltered);
            Bitmap imageResult = edgeDetection.filter(original, "Prewitt3x3Horizontal", "Prewitt3x3Vertical");
            Compare.CompareBitmap(iEdgeDetection.filter(original, "Prewitt3x3Horizontal", "Prewitt3x3Vertical"), imageResult);
        }

        [TestMethod]
        public void kirschMatrixTest()
        {
            Bitmap imageFiltered = Resource1.kirschPenguins;
            iEdgeDetection.filter(original, "Kirsch3x3Horizontal", "Kirsch3x3Vertical").Returns(imageFiltered);
            Bitmap imageResult = edgeDetection.filter(original, "Kirsch3x3Horizontal", "Kirsch3x3Vertical");
            Compare.CompareBitmap(iEdgeDetection.filter(original, "Kirsch3x3Horizontal", "Kirsch3x3Vertical"), imageResult);
        }

        [TestMethod]
        public void sobelMatrixTest()
        {
            Bitmap imageFiltered = Resource1.sobelPenguins;
            iEdgeDetection.filter(original, "Sobel3x3Horizontal", "Sobel3x3Vertical").Returns(imageFiltered);
            Bitmap imageResult = edgeDetection.filter(original, "Sobel3x3Horizontal", "Sobel3x3Vertical");
            Compare.CompareBitmap(iEdgeDetection.filter(original, "Sobel3x3Horizontal", "Sobel3x3Vertical"), imageResult);
        }

        [TestMethod]
        public void defaultMatrixTest()
        {
            Bitmap imageFiltered = Resource1.defaultPenguins;
            iEdgeDetection.filter(original, "", "").Returns(imageFiltered);
            Bitmap imageResult = edgeDetection.filter(original, "", "");
            Compare.CompareBitmap(iEdgeDetection.filter(original, "", ""), imageResult);
        }

        [TestMethod]
        public void nullMatrixTest()
        {
            iEdgeDetection.filter(null, "Prewitt3x3Horizontal", "Prewitt3x3Vertical").Returns(i => null);
            Bitmap resultImage = edgeDetection.filter(null, "Prewitt3x3Horizontal", "Prewitt3x3Vertical");
            Assert.IsNull(iEdgeDetection.filter(null, "Prewitt3x3Horizontal", "Prewitt3x3Vertical"));
            Assert.IsNull(resultImage);
        }
    }
}
