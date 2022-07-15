using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Rectangle
    {
        
        public double Area(double Height, double Width)
        {

            return (Height * Width);
        }

        public double Perimeter(double Height, double Width)
        {

            return (2 * (Height + Width));
        }
    }
}
