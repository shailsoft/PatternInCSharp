using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.LogicalProgram
{
    public static class LogicalProgram
    {
        #region Write a C# Sharp program to compute the sum of the two given integer values.If the two values are the same, then return triple their sum
        //Write a C# Sharp program to compute the sum of the two given integer values.
        //If the two values are the same, then return triple their sum
        //Sample Input:
        //1, 2     
        //3, 2
        //2, 2      
        //Expected Output:
        //3
        //5
        //12    2 2 =4 *3=12 

        public static void ReturnTripple(int x, int y)
        {
            Console.WriteLine(x == y ? (x + y) * 3 : (x + y));
        }

        #endregion

        #region Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
        //Sample Input:
        //30, 0
        //25, 5
        //20, 30
        //20, 25
        //Expected Output:
        //True
        //True
        //True
        //False

        public static void Test(int x, int y)
        {
            Console.WriteLine(x == 30 || y == 30 || (x + y == 30));
        }

        #endregion

        #region Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
        //Write a C# Sharp program to exchange the first and last characters in a given
        //string and return the new string.

        //Sample Input:
        //"abcd"
        //"a"
        //"xy"
        //Expected Output:

        //dbca
        //a
        //yx

        public static void ReplaceFirstToLast(string str)
        {
            var data = str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
            Console.WriteLine(data);
        }
        #endregion
        #region Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7
        //Sample Input:
        //3
        //14
        //12
        //37
        //Expected Output:
        //True
        //True
        //True
        //False

        public static void CheckGivenNumber(int x)
        {
            var data = x % 3 == 0 || x % 7 == 0 ? true : false;
            Console.WriteLine(data);
        }
        #endregion

        #region Write a C# Sharp program to count the number of times the string "aa" appears in a given string and assume that "aaa" contains two "aa".
        //Write a C# Sharp program to count the number of times the string "aa" appears in a given string and assume that "aaa" contains two "aa".

        public static void CheckExist()
        {
            string s = "bbaaccaag";

            int ctr_aa = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s.Substring(i, 2) == "aa")
                {
                    ctr_aa++;
                }
            }
            Console.WriteLine(ctr_aa);

            ////////////////////////
            // Console.WriteLine(test(new[] { 5, 5, 2 }));
            //Console.WriteLine(test(new[] { 5, 5, 2, 5, 5 }));

            //Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers. Also count the situation where the second 5 is actually a 6.
            int[] numbers = { 5, 5, 2 };
            var ctr = 0;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i].Equals(5) && (numbers[i + 1].Equals(5) || numbers[i + 1].Equals(6))) ctr++;
            }

        }
        #endregion

        #region MyRegion
        public static bool ExistInArray(int[] numbers, int n)
        {
            if (numbers.Contains(n))
                return true;
            return false;
        }
        #endregion

        #region MyRegion
        //        Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers. Go to the editor

        //Sample Input:
        //1, 2, 3
        //4, 5, 6
        //-1, 1, 0
        //Expected Output:
        //True
        //False
        //True

        public static void CheckFirstNdSecNumberEqualToThird(int x, int y, int z)
        {
            Console.WriteLine((x + y) == z ? true : false);
        }

        #endregion

        #region Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string
        // Write a program in C# Sharp to count a total number of alphabets, digits and special
        // characters in a string

        //Input the string : Welcome to w3resource.com
        //Expected Output :

        //Number of Alphabets in the string is : 21 
        //Number of Digits in the string is : 1 
        //Number of Special characters in the string is : 4 

        public static void NumberofAlphabetsDigits()
        {
            string str;
            int alp, digit, splch, i;
            alp = digit = splch = i = 0;

            string ch = string.Empty;

            Console.Write("\n\nCount total number of alphabets, digits and special characters :\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();


            /* Checks each character of string*/

            while (i < str.Length)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alp++;
                    ch += str[i];
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    splch++;
                }

                i++;
            }

            Console.Write("Number of Alphabets in the string is : {0}\n", alp);
            Console.Write("Number of Digits in the string is : {0}\n", digit);
            Console.Write("Number of Special characters in the string is : {0}\n\n", splch);
        }

        #endregion
        #region Write a program in C# Sharp to display the name of the days of a week.
        public static void DisplayName()
        {
            string[] dayname = { "Sunday", "Monday", "Tuesday", "Thirsday", "Friday", "Saturday" };

            var result = from objdays in dayname select objdays;

        }
        #endregion
    }
}
