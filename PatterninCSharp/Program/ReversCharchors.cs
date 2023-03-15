using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Program
{
    public static class ReversCharchors
    {
        public static void ReversChar()
        {
            //Input: s = “i am a developer”
            //Output: s = “repoleved a ma i”
            #region First way
            string strVal = "i am a developer", reversValue = string.Empty;
            for (int i = strVal.Length - 1; i >= 0; i--)
            {
                reversValue = reversValue + strVal[i];
                // reversValue += strVal[i]; we can use both
            }
            Console.WriteLine("Your num ={0}", reversValue);
            #endregion
            #region Second way
            string inputstring = string.Empty, outputstring = string.Empty;
            inputstring = Console.ReadLine();
            char[] chars = inputstring.ToCharArray();
            Array.Reverse(chars);
            outputstring = new string(chars);
            Console.WriteLine(outputstring);
            #endregion

            char[] charArray = strVal.ToCharArray();
            for (int i = 0, j = strVal.Length - 1; i < j; i++, j--)
            {
                charArray[i] = strVal[j];
                charArray[j] = strVal[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);

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
        public static void ReverseNumber()
        {
            int inputNumber, reverseNumber = 0;
            inputNumber = int.Parse(Console.ReadLine());

            while (inputNumber != 0)
            {
                reverseNumber = reverseNumber * 10;
                reverseNumber = reverseNumber + inputNumber % 10;
                inputNumber = inputNumber / 10;
            }
            Console.WriteLine("The reverse number is {0}", reverseNumber);
        }
        //Write a program in C# Sharp to display the number in reverse order. Go to the editor Test Data:
        //Input a number: 12345
        public static void ReverseNumberSecWay()
        {
            int num, r, reverse = 0, t;
            Console.WriteLine("Display the number in reverse order:\n--------------------------------------");
            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; t != 0; t = t / 10)
            {
                r = t % 10;
                reverse = reverse * 10 + r;
            }
            Console.Write("The number in reverse order is : {0} \n", reverse);
        }
    }
}

