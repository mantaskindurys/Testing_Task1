using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTask1.Two_Dimensional
{
    public class Square
    {
        public double GetPerimeter(double sideLenght)
        {
            if(sideLenght <= 0)
            {
                throw new System.ArgumentException("Parameter cannot be less or equal to 0", "sideLenght");
            }
            else
            {
                double perimeter = sideLenght * 4;
                return perimeter;
            }
            
        }

        public double GetArea(double sideLenght)
        {
            if (sideLenght <= 0)
            {
                throw new System.ArgumentException("Parameter cannot be less or equal to 0", "sideLenght");
            }
            else
            {
                double area = sideLenght * sideLenght;
                return area;
            }
        }

    }
}
