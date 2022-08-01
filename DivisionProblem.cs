using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class DivisionProblem
    {
        public static void CheckQutientAndRemainder()
        {
            int dividend = 50, divisor = 0;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient :" + quotient);

            Console.WriteLine("Remainder :" + remainder);
        }
    }
}
