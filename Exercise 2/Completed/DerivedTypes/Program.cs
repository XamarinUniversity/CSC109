using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Operation> operations = new List<Operation>();
            operations.Add(new AddOperation(10, 20));
            operations.Add(new MultiplyOperation(10, 20));

            foreach (Operation op in operations)
            {
                Console.WriteLine(op.Calculate());
            }
        }
    }
}
