using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabetes
{
    internal class CheckVowel
    {
        public void Vowel()
        {
            Console.WriteLine("Enter the alphabete for checking vowel or not");
            char ch = Convert.ToChar(Console.ReadLine());

            while (ch <= 'a' || ch >= 'z')
            {
                Console.WriteLine("Please enter alphabetes only");
                ch = Convert.ToChar(Console.ReadLine());
            }

            if ((ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u'))
            {
                Console.WriteLine("Alphabete is Vowel");
            }
            else
            {
                Console.WriteLine("Alphabete is Not a Vowel");
            }
        }
    }
}
