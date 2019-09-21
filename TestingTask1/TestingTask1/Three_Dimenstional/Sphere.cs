using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTask1.Three_Dimenstional
{
    public class Sphere
    {
        public double GetSurfaceArea(double r)
        {
            double pi = 3.14;
            if (r <= 0)
            {
                throw new System.ArgumentException("Values cannot be less or equal to 0", "r");
            }
            else
            {
                double Area = 4 * pi * r * r;
                return Area;
            }
        }

        public double GetVolume(double r)
        {
            double pi = 3.14;
            if (r <= 0)
            {
                throw new System.ArgumentException("Values cannot be less or equal to 0", "r");
            }
            else
            {
                double Volume = (3 / 4) * pi * (r * r * r);
                return Volume;
            }
        }

    }
}
