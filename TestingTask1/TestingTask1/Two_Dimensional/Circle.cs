using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTask1.Two_Dimensional
{
    public class Circle
    {
        public double GetCircumference(double r)
        {
            double Pi = 3.14;
            if (r <= 0)
            {
                throw new System.ArgumentException("Values cannot be less or equal to 0", "r");
            }
            else
            {
                double Cir = (2 * Pi * r);
                return Cir;
            }
            
        }

        public double GetArea(double r)
        {
            double Pi = 3.14;
            if (r <= 0)
            {
                throw new System.ArgumentException("Values cannot be less or equal to 0", "r");
            }
            else
            {
                double Area = (Pi * r * r);
                return Area;
            }
        }
    }
}
