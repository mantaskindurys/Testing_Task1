using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingTask1.Two_Dimensional;

namespace TestingTask1.Three_Dimenstional
{
    public class Cylinder
    {
        public double GetSurfaceArea(double radius,double height)
        {
            double pi = 3.14;
            if (radius <= 0 || height <= 0)
            {
                throw new System.ArgumentException("Values cannot be less or equal to 0", "radius, height");
            }
            else
            {
                double surfaceArea = (2 * pi * radius * height + (2 * pi * radius * radius));
                return surfaceArea;
            }
        }

        public double GetVolume(double radius, double height)
        {
            double pi = 3.14;
            if (radius <= 0 || height <= 0)
            {
                throw new System.ArgumentException("Values cannot be less or equal to 0", "radius, height");
            }
            else
            {
                double volume = (pi * radius * radius * height);
                return volume;
            }
        }

        public double GetBase(double radius)
        {
            Circle circle = new Circle();  
            double result = circle.GetCircumference(radius);
            return result;
        }


    }
}
