using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary.Tests
{
    [TestClass()]
    public class SquareLibraryTests
    {
        [TestMethod()]
        public void TriangleTest_Constructor_with_valid_data()
        {
            // Arrange
            double side1 = 2;
            double side2 = 3;
            double side3 = 4;

            //Act
            Triangle triangle = new Triangle(side1, side2, side3);

            // Assert
            Assert.IsNotNull(triangle);
            Assert.AreEqual(side1, triangle.SideOne);
            Assert.AreEqual(side2, triangle.SideTwo);
            Assert.AreEqual(side3, triangle.SideThree);
        }
        [TestMethod()]
        public void TriangleTest_Constructor_with_invalid_data()
        {
            // Arrange
            double side1 = -2;
            double side2 = -3;
            double side3 = -4;

            //Act
            Triangle triangle = null;

            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { triangle = new Triangle(side1, side2, side3); });
            
        }
        [TestMethod()]
        public void TriangleTest_Square()
        {
            //Arrange
            double side1 = 5;
            double side2 = 3;
            double side3 = 4;
            double expected = 6;

            //Act
            Triangle triangle = new Triangle(side1, side2, side3);
            var square = triangle.CalculateSquare();

            //Assert
            Assert.AreEqual(expected, square);
        }
        [TestMethod()]
        public void TriangleTest_Rectangular()
        {
            //Arrange
            double side1 = 5;
            double side2 = 3;
            double side3 = 4;
            
            //Act
            Triangle triangle = new Triangle(side1, side2, side3);

            //Assert
            Assert.IsTrue(triangle.IsRectangular());
        }
        [TestMethod()]
        public void CircleTest_Constructor_with_valid_data()
        {
            //Arrange
            double radius = 5;

            //Act
            Circle circle = new Circle(radius);

            //Assert
            Assert.AreEqual(radius, circle.Radius);
        }
        [TestMethod()]
        public void CircleTest_Constructor_with_invalid_data()
        {
            //Arrange
            double radius = -5;
            Circle circle = null;

            //Act
            

            //Assert
            Assert.ThrowsException<ArgumentException>(() => { circle = new Circle(radius); });
        }
        [TestMethod()]
        public void CircleTest_Square()
        {
            //Arrange
            double radius = 17.5;
            double expected = Math.PI*radius*radius;

            //Act
            Circle circle = new Circle(radius);
            var square = circle.CalculateSquare();

            //Assert
            Assert.AreEqual(expected, square);
        }
    }
}