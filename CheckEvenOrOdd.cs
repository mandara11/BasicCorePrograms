using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class CheckEvenOrOdd
    {
        public static void EvenOrOdd()
        {
            int number;
            Console.Write("Enter the Number :");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("{0} is Even Number", number);
            else
                Console.WriteLine("{0} is Odd Number", number);
        }
    }
}
