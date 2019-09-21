using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingTask1.Two_Dimensional;

namespace TestingTask1.Three_Dimenstional
{
    public class SquarePyramid
    {
        public double GetSurficeArea(double squarePyramidBase, double squarePyramidSlant)
        {
            if (squarePyramidBase <= 0 || squarePyramidSlant <= 0 )
            {
                throw new System.ArgumentException("Parameter cannot be less or equal to 0", "squarePyramidBase, squarePyramidSlant ");
            }
            else
            {
                double surface = 2 * squarePyramidBase * squarePyramidSlant + (squarePyramidBase * squarePyramidBase);
                return surface;
            }
        }

        public double GetVolume(double squarePyramidBase, double squarePyramidHeight)
        {
            if (squarePyramidBase <= 0 || squarePyramidHeight <= 0)
            {
                throw new System.ArgumentException("Parameter cannot be less or equal to 0", "squarePyramidBase, squarePyramidHeight ");
            }
            else
            {
                double volume = (1 / 3) * (squarePyramidBase * squarePyramidBase) * squarePyramidHeight;
                return volume;
            }
        }

        public double GetBase(double squarePyramidBase)
        {
            Square square = new Square();
            double result = square.GetArea(squarePyramidBase);
            return result;
        }
    }
}
