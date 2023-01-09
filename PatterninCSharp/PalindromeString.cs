using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp
{
    public static class PalindromeString
    {
        public static void PalindromeStringOrNot()
        {
            string? str = string.Empty;
            Console.WriteLine("Enter a string : ");
            str = Console.ReadLine();

            char[] chrArray = str.ToCharArray();
            Array.Reverse(chrArray);
            string str_Revchtor = new string(chrArray);
            if (str == str_Revchtor)
            {
                Console.WriteLine("Palindome Number : " + str);
            }
            else
            {
                Console.WriteLine("Not Palindome Number : " + str);

            }

        }
    }
}
