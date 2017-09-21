namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double _base, double height)
        {
            Length = _base;
            Width = height;
        }
        public override string DescribeSelf()
        {
            return "Triangle - base: " + Length + " height: " + Width;
        }
        public override double GetArea()
        {
            return (Length * Width) / 2;
        }
    }
}
