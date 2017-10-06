using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedTypes
{
    public class MultiplyOperation : Operation
    {
        public MultiplyOperation(int n1, int n2)
            : base(n1, n2)
        {
        }

        public string Calculate()
        {
            return string.Format("{0} X {1} = {2}",
                FirstNumber, SecondNumber,
                FirstNumber * SecondNumber);
        }
    }
}
