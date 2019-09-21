using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingTask1.Two_Dimensional;
using TestingTask1.Three_Dimenstional;

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

            Triangle triangle = new Triangle();
            double expectedResult = triangleBase + side1 + side2;

            double actual = triangle.GetPerimeter(triangleBase, side1, side2);

            Assert.AreEqual(expectedResult, actual, 0);

        }

        [TestMethod]
        public void TestMethodGetArea()
        {
            double triangleBase = 20;
            double triangleHeight = 12;

            Triangle triangle = new Triangle();
            double expectedResult = (triangleBase * triangleHeight) / 2;

            double actual = triangle.GetArea(triangleBase, triangleHeight);

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

    [TestClass]
    public class SphereTest
    {
        [TestMethod]
        public void TestGetSurficeArea()
        {
            double r = 5;
            double pi = 3.14;
            double expectedResult = 4 * pi * (r * r);
            double actual = Sphere.GetSurficeArea(r);
            Assert.AreEqual(expectedResult, actual, 0);
        }

        [TestMethod]
        public void TestGetVolume()
        {
            double r = 5;
            double pi = 3.14;
            double expectedResult = (3 / 4) * pi * (r * r * r);
            double actual = Sphere.GetVolume(r);
            Assert.AreEqual(expectedResult, actual, 0);
        }
    }

    [TestClass]
    public class SquarePyramidTest
    {
        [TestMethod]
        public void TestGetSurficeArea()
        {
            double squarePyramidBase = 5;
            double squarePyramidSlant = 8;

            double expectedResult = 2 * squarePyramidBase * squarePyramidSlant + (squarePyramidBase * squarePyramidBase);
            double actual = SquarePyramid.GetSurficeArea(squarePyramidBase, squarePyramidSlant);

            Assert.AreEqual(expectedResult, actual, 0);


        }

        [TestMethod]
        public void TestGetVolume()
        {
            double squarePyramidBase = 5;
            double squarePyramidHeight = 5;

            double expectedResult = (1 / 3) * (squarePyramidBase * squarePyramidBase) * squarePyramidHeight;
            double actual = SquarePyramid.GetVolume(squarePyramidBase, squarePyramidHeight);
            Assert.AreEqual(expectedResult, actual, 0);
        }

        [TestMethod]
        public void TestGetBase()
        {
            double squarePyramidBase = 9;

            double expectedResult = squarePyramidBase * squarePyramidBase;
            double actual = SquarePyramid.GetBase(squarePyramidBase);
            Assert.AreEqual(expectedResult, actual, 0);


        }
    }

    [TestClass]
    public class CylinderTest
    {
        [TestMethod]
        public void TestGetSurfaceArea()
        {
            Cylinder cylinder = new Cylinder();
            double r = 4;
            double height = 5;
            double pi = 3.14;
            double expectedResult = (2*pi * r * height+(2*pi*r*r));
            double actual = cylinder.GetSurfaceArea(r, height);
            Assert.AreEqual(expectedResult, actual, 0);
        }

        [TestMethod]
        public void TestGetVolume()
        {
            Cylinder cylinder = new Cylinder();
            double r = 4;
            double height = 5;
            double pie = 3.14;
            double expectedResult = (pie * r * r * height);
            double actual = cylinder.GetVolume(r,height);
            Assert.AreEqual(expectedResult, actual, 0);
        }

        [TestMethod]
        public void TestGetBase()
        {
            Cylinder cylinder = new Cylinder();
            double r = 4;
            double pi = 3.14;
            double expectedResult = (pi * r * r);
            double actual = cylinder.GetBase(r);
            Assert.AreEqual(expectedResult, actual, 0);
        }
    }

    [TestClass]
    public class ConeTest
    {
        [TestMethod]
        public void TestGetSurficeArea()
        {
            Cone cone = new Cone();
            double r = 4;
            double slant = 3;
            double pi = 3.14;
            double expectedResult = (pi * r * slant + (pi*r*r));
            double actual = cone.GetSurfaceArea(r, slant);
            Assert.AreEqual(expectedResult, actual, 0);
        }

        [TestMethod]
        public void TestGetVolume()
        {
            Cone cone = new Cone();
            double r = 4;
            double height = 3;
            double pi = 3.14;
            double expectedResult = (pi * r * r *(height/3));
            double actual = cone.GetVolume(r,height);
            Assert.AreEqual(expectedResult, actual, 0);
        }

        [TestMethod]
        public void TestGetBase()
        {
            Cone cone = new Cone();
            double r = 4;
            double pi = 3.14;
            double expectedResult = (pi * r * r);
            double actual = cone.GetBase(r);
            Assert.AreEqual(expectedResult, actual, 0);
        }
    }
}
