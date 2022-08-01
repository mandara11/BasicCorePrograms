using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class LargestAmongThreeNumbers
    {
        public static void FindLargestAmongThreeNumbers()
        {
            int a, b, c;
            Console.Write("Enter the value of A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of C: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine("A is Largest");
            else if (b > c)
                Console.WriteLine("B is Largest");
            else if (c > b)
                Console.WriteLine("C is Largest");
            else
                Console.WriteLine("All numbers are equal");

            Console.ReadKey();
        }
    }
}
