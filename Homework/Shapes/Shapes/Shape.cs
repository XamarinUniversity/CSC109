using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public double Length { get; protected set; }
        public double Width { get; protected set; }

        public abstract double GetArea();
        public abstract string DescribeSelf();

        public override string ToString()
        {
            return DescribeSelf();
        }
    }
}
