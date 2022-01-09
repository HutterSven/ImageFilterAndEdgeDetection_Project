using ImageFilterAndEdgeDetection_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Drawing;

namespace ImageFilterAndEdgeDetection_ProjectTest
{
    /// <summary>
    /// DataAccessClass test class for test the methods of the DataAccessClass
    /// </summary>
    [TestClass]
    public class DataAccessClassTest
    {
        private AccessData accessData = new AccessData();
        private IAccessData iAccessData = Substitute.For<IAccessData>();

        /// <summary>
        /// load image test for correct execution
        /// </summary>
        [TestMethod]
        public void _OpenFile_Should_Return_Bitmap()
        {
            //Arrange
            Bitmap bitmap = Resource1.originalPenguins;
            string path = @"..\..\..\Resources\originalPenguins.png";
            //Act
            iAccessData.LoadImage(path).Returns(bitmap);

            Bitmap resultImage = iAccessData.LoadImage(path);
            //Assert
            Compare.CompareBitmap(accessData.LoadImage(path), resultImage);
        }

        /// <summary>
        /// load image test for no path param
        /// </summary>
        [TestMethod]
        public void _OpenFile_Should_Return_Null()
        {
            //Arrange
            Bitmap bitmap = null;
            string path = "";
            //Act
            iAccessData.LoadImage(path).Returns(bitmap);

            Bitmap resultImage = iAccessData.LoadImage(path);
            //Assert
            Assert.AreEqual(accessData.LoadImage(path), resultImage);
        }

        /// <summary>
        /// save image test for correct execution
        /// </summary>
        [TestMethod]
        public void _SaveFile_Should_Save_Image()
        {
            //Arrange
            Bitmap bitmap = Resource1.originalPenguins;
            string path = @"..\..\..\Resources\saveImageTestSubstitute.png";
            //Act
            accessData.SaveImage(bitmap, path);

            Bitmap resultImage = new Bitmap(path);

            Compare.CompareBitmap(bitmap, resultImage);
        }

        /// <summary>
        /// save image test for no path param
        /// </summary>
        [TestMethod]
        public void _SaveFile_Should_Return_ArgumentExeption_On_Path_Null()
        {
            //Arrange
            Bitmap bitmap = Resource1.originalPenguins;
            string path = null;
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => accessData.SaveImage(bitmap, path));
        }

        /// <summary>
        /// save image test for empty string path
        /// </summary>
        [TestMethod]
        public void _SaveFile_Should_Return_ArgumentExeption_On_Path_Empty_String()
        {
            //Arrange
            Bitmap bitmap = Resource1.originalPenguins;
            string path = @"";
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => accessData.SaveImage(bitmap, path));
        }

        /// <summary>
        /// save image test for no bitmap param
        /// </summary>
        [TestMethod]
        public void _SaveFile_Should_Return_ArgumentExeption_On_Bitmap()
        {
            //Arrange
            Bitmap bitmap = null;
            string path = @"..\..\..\Resources\saveImageTestSubstitute.png";
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => accessData.SaveImage(bitmap, path));
        }


    }
}
