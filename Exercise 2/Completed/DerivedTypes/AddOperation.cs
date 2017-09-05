namespace DerivedTypes
{
    public class AddOperation : Operation
    {
        public AddOperation(int n1, int n2)
            :base (n1,n2)
        {
        }

        public override string Calculate()
        {
            return string.Format("{0} + {1} = {2}", FirstNumber, SecondNumber, FirstNumber + SecondNumber);
        }
    }


}

