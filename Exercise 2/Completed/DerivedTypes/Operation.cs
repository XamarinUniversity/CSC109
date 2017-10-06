using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedTypes
{
    public abstract class Operation
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public Operation(int n1, int n2)
        {
            FirstNumber = n1;
            SecondNumber = n2;
        }

        public abstract string Calculate();

    }
}
