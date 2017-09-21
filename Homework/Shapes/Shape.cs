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
