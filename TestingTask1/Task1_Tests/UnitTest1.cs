using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingTask1._2_Dimensional;

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
            Rectangle Rectangle = new Rectange();
            double Lenght = 4;
            double Height = 4;
            expectedResult = (Lenght * x) + (Height * 2);
            double actual = Rectangle.GetPerimeter(Lenght, Height);
            Assert.AreEqual(expectedResult, actual, 0);
        }

        [TestMethod]
        public void TestMethodGetArea()
        {
            Rectangle Rectangle = new Rectange();
            double Lenght = 4;
            double Height = 4;
            expectedResult = (Lenght * Height);
            double actual = Rectangle.GetArea(Lenght, Height);
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
            double pi = 3.14;
            expectedResult = (2 * pi * r);
            double actual = Circle.GetCircumference(r);
            Assert.AreEqual(expectedResult, actual, 0);
        }

        [TestMethod]
        public void TestMethodGetArea()
        {
            Circle Circle = new Circle();
            double r = 4;
            double pi = 3.14;
            expectedResult = (pi * r * r);
            double actual = Circle.GetArea(r);
            Assert.AreEqual(expectedResult, actual, 0);
        }
    }

}
