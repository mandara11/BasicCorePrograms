using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class SwapTwoNumbers
    {
        public static void Swaping()
        {
            int a = 5, b = 10;

            Console.WriteLine("Before Swap a = " + a + "b = " + b);

            a = a * b;
            b = b / a;
            a = a / b;

            Console.WriteLine("after Swap a = " + a + "b =" + b);
        }
    }
}
