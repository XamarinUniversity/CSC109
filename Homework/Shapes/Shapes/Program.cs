using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle(50, 100));
            shapes.Add(new Rectangle(22, 44));
            shapes.Add(new Triangle(10, 12));
            shapes.Add(new Square(5));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape + " Area: "+shape.GetArea());
            }
        }
    }
}
