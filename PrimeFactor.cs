using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class PrimeFactor
    {
        public static void FindPrimeFactors()
        {
            Console.WriteLine("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());
            int i = 2;
            while (userInput > 1)
            {
                Console.WriteLine(i);
                userInput = userInput / i;
            }
            i++;
        }
    }
}
