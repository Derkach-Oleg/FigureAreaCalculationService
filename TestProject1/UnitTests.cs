using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureAreaCalculationService.UnitTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void isStraightTriangle_NotStraight_ReturnFalse()
        {
            //Arrange
            Triangle triangle = new Triangle(5, 4, 6);

            //Act
            var result = triangle.isStraightTriangle();

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void FindArea_3and4and5_Return6()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 6;

            //Act
            var result = triangle.FindArea();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Square_5_Return78_5()
        {
            //Arrange
            Circle circle = new Circle(5);
            double expected = 78.5;

            //Act
            var result = circle.FindArea();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
