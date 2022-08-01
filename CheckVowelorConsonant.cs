using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class CheckVowelorConsonant
    {
        public static void Check()
        {
            Console.WriteLine("Check Vowel Consonent Program");
            Console.WriteLine("Enter Character:");

            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " character is vowel");
            }
            else if ((ch>='a' && ch<='z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("The Character Is Consonant");
            }
        
        }
    }
}
