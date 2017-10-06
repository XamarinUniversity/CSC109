using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string DescribeSelf()
        {
            return "Rectangle - length: " + Length + " width: " + Width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }
    }
}
