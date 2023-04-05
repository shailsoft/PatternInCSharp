using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Program
{
    public static class FindVowelsAndConsFromArray
    {
        public static int FindVowelsWithHelpArray(String inputString)
        {
            int vowelCounter = 0;
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            if (inputString != null)
            {
                foreach (char c in inputString.ToLower())
                {
                    if (vowels.Contains(c))
                    {
                        vowelCounter++;
                    }
                }
            }

            /////////////////////// s
            // second way
            int vowel_count = 0;
            int cons_count = 0;
            string inputStr = "Avengers";
            for (int i = 0; i < inputStr.Length; i++)
            {
                if (inputStr[i] == 'a' || inputStr[i] == 'e' || inputStr[i] == 'i'
                    || inputStr[i] == 'o' || inputStr[i] == 'u' || inputStr[i] == 'A'
                    || inputStr[i] == 'E' || inputStr[i] == 'I' || inputStr[i] == 'O'
                    || inputStr[i] == 'U')
                {
                    vowel_count++;
                }
                else
                {
                    cons_count++;
                }
            }
            Console.WriteLine("vowel_count : " + vowel_count);
            Console.WriteLine("cons_count {0}", + cons_count);
            return vowelCounter;
        }
    }
}
