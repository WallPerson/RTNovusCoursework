using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Circle
    {
        public double Area(double Radius)
        {


           return (Math.PI * Math.Pow(Radius, 2));

        }

        public double Perimeter(double Radius)
        {

            return (2 * Math.PI * Radius);

        }
    }
}
