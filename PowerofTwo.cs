using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class PowerofTwo
    {
        public static void PowerValue()
        {
            Console.WriteLine("Enter value of n for calculating 2^n");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0 || num > 30)
            {
                Console.WriteLine("Please enter number between 0 to 30");
            }
            else
            {
                // Console.WriteLine("Power of 2^" + num + " is: " + (Math.Pow(2, num)));
                Console.WriteLine();
                Console.WriteLine("Printing all till Power Value " + num);


                for (int i = 0; i <= num; i++)
                {
                    Console.WriteLine("Power of 2^" + i + " is: " + (Math.Pow(2, i)));
                }
            }
        }
    }
}
