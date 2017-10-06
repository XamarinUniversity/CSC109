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
            // Perform an "Add" operation
            AddOperation add = new AddOperation(10, 20);
            Console.WriteLine(add.Calculate());

            // TODO: perform a "Multiply" operation
        }
    }
}
