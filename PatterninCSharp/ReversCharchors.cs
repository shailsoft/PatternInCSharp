using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp
{
    public static class ReversCharchors
    {
        public static void ReversChar()
        {
            //Input: s = “i am a developer”
            //Output: s = “repoleved a ma i”

            string strVal = "i am a developer", reversValue = String.Empty;
            //Console.WriteLine("Enter the Vlaues");
            //strVal =Console.ReadLine();

            for (int i = strVal.Length - 1; i >= 0; i--)
            {
                reversValue = reversValue + strVal[i];
                // reversValue += strVal[i]; we can use both
            }
            Console.WriteLine("Your num ={0}", reversValue);
        }
        public static void ReversCharWithoutChngPosition()
        {
            //Input: s = “one two three four five”
            //Output: s = “eno owt eerht ruof evif”

            string inputV = "one two three four five";
            string result = string.Join(" ", inputV.Split(' ').
                             Select(x => new string(x.Reverse()
                             .ToArray())));

            Console.WriteLine(result);

            Console.WriteLine("one two three ={0}", result);
        }
        public static void ReversWordWithoutChngPosition()
        {
            //Input: s = “i like this program very much”
            //Output: s = “much very program this like i”
            string s = "i like this program very much";
            string result = string.Empty;

            string[] a = s.Split(' ');
            Array.Reverse(a);
            for (int i = 0; i <= a.Length - 1; i++)
            {
                result = result + a[i] + "" + ' '; 
                
            }
            Console.Write(result);
        }
    }
}
