using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTask1.Two_Dimensional
{
    public class Triangle
    {
        public double GetPerimeter(double triangleBase, double side1, double side2)
        {

            if (triangleBase <= 0 || side1<=0 || side2<=0 )
            {
                throw new System.ArgumentException("Parameter cannot be less or equal to 0", "triangleBase, side1, side2 ");
            }
            else
            {
                double perimeter = triangleBase+ side1+ side2;
                return perimeter;
            }
        }

        public double GetArea(double triangleBase, double triangleHeight)
        {
            if (triangleBase <= 0 || triangleHeight <= 0)
            {
                throw new System.ArgumentException("Parameter cannot be less or equal to 0", "triangleBase, side1, side2 ");
            }
            else
            {
                double area = triangleBase * triangleHeight *0.5;
                return area;
            }
        }
    }
}
