using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class CheckLeapyear
    {
        public static void Leapyear()
        {
            Console.WriteLine("Enter the year");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (Year/1000 !=0 && Year/1000<10)
            {
                Console.WriteLine("Entered number is Four digit");
            }
            else
            {
                Console.WriteLine("Entered number is not a Four digit");
            }

            Console.WriteLine("The User Entered year is " +Year);
            if (((Year %4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("Entered Year is Leap Year");
            }
            else
            {
                Console.WriteLine("Entered Year is not a Leap Year");
            }
        }
    }
}
