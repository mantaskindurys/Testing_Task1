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
            double sideLenght = 4;
            double expectedResult;

            expectedResult = sideLenght * sideLenght;

            Square Square = new Square();

            double actual = Square.GetArea(sideLenght);

            Assert.AreEqual(expectedResult, actual, 0);
        }

    }

    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void TestMethodGetPerimeter()
        {

            Rectangle Rectangle = new Rectangle();
            double Lenght = 4;
            double Height = 4;
            double expectedResult = (Lenght * 2) + (Height * 2);
            double actual = Rectangle.GetPerimeter(Lenght, Height);
            Assert.AreEqual(expectedResult, actual, 0);
        }

        [TestMethod]
        public void TestMethodGetArea()
        {
            Rectangle Rectangle = new Rectangle();
            double Lenght = 4;
            double Height = 4;
            double expectedResult = (Lenght * Height);
            double actual = Rectangle.GetArea(Lenght, Height);
            Assert.AreEqual(expectedResult, actual, 0);
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
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestMethodGetCircumference()
        {
            Circle Circle = new Circle();
            double r = 4;
            double pie = 3.14;
            double expectedResult = (2 * pie * r);
            double actual = Circle.GetCircumference(r);
            Assert.AreEqual(expectedResult, actual, 0);
        }

        [TestMethod]
        public void TestMethodGetArea()
        {
            Circle Circle = new Circle();
            double r = 4;
            double pi = 3.14;
            double expectedResult = (pi * r * r);
            double actual = Circle.GetArea(r);
            Assert.AreEqual(expectedResult, actual, 0);
        }
    }
}
