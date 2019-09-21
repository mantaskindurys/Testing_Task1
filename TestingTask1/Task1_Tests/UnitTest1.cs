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

            double actual = Square.getPerimeter(sideLenght);

            Assert.AreEqual(expectedResult, actual, 0);
            
        }

        [TestMethod]
        public void TestMethodGetArea()
        {
        }

    }
}
