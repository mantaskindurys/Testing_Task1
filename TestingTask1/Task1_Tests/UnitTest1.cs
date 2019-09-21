using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingTask1.Two_Dimensional;

namespace Task1_Tests
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void TestMethodGetPerimeter()
        {
            double sideLenght = 4;
            double expectedResult;

            expectedResult = sideLenght * 4;

            Square Square = new Square();

            double actual = Square.GetPerimeter(sideLenght);

            Assert.AreEqual(expectedResult, actual, 0);
            
        }

        [TestMethod]
        public void TestMethodGetArea()
        {
        }

    }

    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestMethodGetPerimeter()
        {
            double triangleBase = 4;
            double side1 = 4;
            double side2 = 4;

            double expectedResult;

            expectedResult = triangleBase + side1 + side2;



            double actual = Triangle.GetPerimeter(triangleBase, side1, side2);

            Assert.AreEqual(expectedResult, actual, 0);

        }

        [TestMethod]
        public void TestMethodGetArea()
        {
            double triangleBase = 20;
            double triangleHeight = 12;
            double expectedResult;


            expectedResult = (triangleBase * triangleHeight) / 2;

            double actual = Triangle.GetArea(triangleBase, triangleHeight);

            Assert.AreEqual(expectedResult, actual, 0);
        }

    }
}
