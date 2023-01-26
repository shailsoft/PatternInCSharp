﻿using System;
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

            // second way
            // input s= "i am developer";
            //output s = "i ma repoleved"
            string str = "i am developer";

            string[] strArr = str.Split(' ');
            var reverceChar = strArr.Select(x => new string(x.Reverse().ToArray()));
            string RevResult = string.Join(" ", reverceChar);
            Console.WriteLine(result);
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

            string str = "i am developer";
            string[] strArr = str.Split(' ');
            Array.Reverse(strArr);
            string res = string.Join(" ", strArr);
            Console.WriteLine(res);
        }
        public static void FindDuplicate()
        {
            string data = "i am a developer";
            var resw = (from obj in data select obj).GroupBy(x => x).First();
            Console.WriteLine("tha value is {0}" + resw);
        }
        public static void FindPrimeNumberOrNot()
        {
            int num, res, reve = 0;
            Console.WriteLine("Please Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    reve++;
                    break;
                }
            }
            if (reve == 0 && num != 1)
            {
                Console.Write("{0} is prime number \n ", +num);
            }
            else
            {
                Console.Write("{0} is not Prime Number\n", +num);
            }
            Console.ReadLine();
        }
    }
}
