namespace Shapes
{
    public class Square : Rectangle
    {
        public Square(double side) 
            : base(side, side)
        {
        }
        public override string DescribeSelf()
        {
            return "Square - length: " + Length;
        }
    }
}
