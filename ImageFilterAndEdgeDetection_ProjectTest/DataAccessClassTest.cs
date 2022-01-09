using ImageFilterAndEdgeDetection_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFilterAndEdgeDetection_ProjectTest
{
    /// <summary>
    /// DataAccessClass test class for test the methods of the DataAccessClass
    /// </summary>
    [TestClass]
    public class DataAccessClassTest
    {
        private DataAccessClass DataAccessClass = new DataAccessClass();
        private IDataAccessClass IDataAccessClass = Substitute.For<IDataAccessClass>();

        [TestMethod]
        public void _OpenFile_Should_Return_Bitmap()
        {
            //Arrange
            Bitmap bitmap = Resource1.originalPenguins;
            string path = @"..\..\Resources\penguins.png";
            //Act
            IDataAccessClass.LoadImage(path).Returns(bitmap);

            Bitmap resultImage = IDataAccessClass.LoadImage(path);
            //Assert
            Compare.CompareBitmap(bitmap, resultImage);
        }

        [TestMethod]
        public void _OpenFile_Should_Return_Null()
        {
            //Arrange
            Bitmap bitmap = null;
            string path = "";
            //Act
            IDataAccessClass.LoadImage(path).Returns(bitmap);

            Bitmap resultImage = IDataAccessClass.LoadImage(path);
            //Assert
            Assert.AreEqual(bitmap, resultImage);
        }

        [TestMethod]
        public void _SaveFile_Should_Save_Image()
        {
            //Arrange
            Bitmap bitmap = Resource1.originalPenguins;
            string path = @"..\..\..\Resources\saveImageTestSubstitute.png";
            DataAccessClass dac = new DataAccessClass();
            //Act
            dac.SaveImage(bitmap, path);

            Bitmap resultImage = new Bitmap(path);

            Compare.CompareBitmap(bitmap, resultImage);
        }

        [TestMethod]
        public void _SaveFile_Should_Return_ArgumentExeption_On_Path()
        {
            //Arrange
            Bitmap bitmap = Resource1.originalPenguins;
            string path = @"";
            DataAccessClass dac = new DataAccessClass();
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => dac.SaveImage(bitmap, path));
        }
        [TestMethod]
        public void _SaveFile_Should_Return_ArgumentExeption_On_Bitmap()
        {
            //Arrange
            Bitmap bitmap = null;
            string path = @"..\..\..\Resources\saveImageTestSubstitute.png";
            DataAccessClass dac = new DataAccessClass();
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => dac.SaveImage(bitmap, path));
        }


    }
}
