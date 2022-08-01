using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Harmonic
    {
        public static void Harmonicseries()
        {
            Console.WriteLine("Enter the n value of harmonic Series");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("1/{0} + ", i);
                }
            }
            else
            {
                Console.WriteLine("Entered Zero number and you need to enter Non Zero number");
            }
        }
    }
}
