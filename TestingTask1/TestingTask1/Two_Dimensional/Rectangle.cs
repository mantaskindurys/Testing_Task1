using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTask1.Two_Dimensional
{
    public class Rectangle
    {
        public double GetPerimeter(double Lenght, double Height)
        {
            if (Lenght <= 0 || Height <=0)
            {
                throw new System.ArgumentException("Parameter cannot be less or equal to 0", "lenght, height");
            }
            else
            {
                double Perimeter = (Lenght * 2) + (Height * 2);
                return Perimeter;
            }
        }

        public double GetArea(double Lenght, double Height)
        {
            if (Lenght <= 0 || Height <= 0)
            {
                throw new System.ArgumentException("Parameter cannot be less or equal to 0", "lenght, height");
            }
            else
            {
                double Area = (Lenght * Height);
                return Area;

            }
        }
    }
}
