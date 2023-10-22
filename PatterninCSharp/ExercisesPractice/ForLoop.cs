
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PatterninCSharp.ExercisesPractice
{
    public class ForLoop
    {
        #region Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1.
        //The pattern like :
        //1
        //2 3
        //4 5 6
        //7 8 9 10 
        public void WordPattern()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'P' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3) && column > 0 && column < 5) || ((column == 5 || column == 1) && (row == 1 || row == 2)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        #endregion
       
        #region Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1.
        //The pattern like :
        //1
        //2 3
        //4 5 6
        //7 8 9 10 

        public void TriangleNumIncreased()
        {
            int row, col, k=1;
            for (row = 1; row <= 10; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("{0} ",k++);
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
        //The pattern like :
        //1
        //12
        //123
        //1234

        public void PatternTriNum()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j= 1; j <i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        #endregion 

        #region Write a C# Sharp program to display the n terms of odd natural numbers and their sums.
        //Test Data
        //Input number of terms : 10
        //Expected Output :
        //The odd numbers are :1 3 5 7 9 11 13 15 17 19
        //The Sum of odd Natural Number upto 10 terms : 100

        public void OddNaturalNumbSum()
        {
            int num, sum = 0;
            Console.WriteLine("Enter integer number");
            num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= num * 2; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.Write("{0} ", i);
            //        sum += i;
            //    }
            //}
            for (int i = 1; i <= num; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine();
            Console.WriteLine("The Sum of odd Natural Number upto {0} terms : {1}", num, sum);
        }
        #endregion 

        #region Write a program in C# Sharp to display the multiplication table of a given integer.
        //Test Data :
        //Input the number(Table to be calculated) : 15
        //Expected Output :
        //15 X 1 = 15
        //...
        //...
        //15 X 10 = 150

        public void MultiplicationOfTable()
        {
            int num;
            Console.WriteLine("Enter integer number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2} ", num, i, (num * i));
            }
        }
        #endregion 

        #region Write a program in C# Sharp to display the first 10 natural numbers. Expected Output :
        //1 2 3 4 5 6 7 8 9 10

        public void DisplayNaturalNumber()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0} ", i);
            }
        }
        #endregion

        #region Write a C# Sharp program to find the sum of the first 10 natural numbers. Expected Output :
        //The first 10 natural number is :
        //1 2 3 4 5 6 7 8 9 10 =55

        public void SumOfNaturalNum()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of natural number {0}=", sum);
        }
        #endregion

        #region Write a C# Sharp program to display the cube of an integer up to given number.
        //        Test Data :
        //Input number of terms : 5
        //Expected Output :
        //Number is : 1 and cube of the 1 is :1
        //Number is : 2 and cube of the 2 is :8
        //Number is : 3 and cube of the 3 is :27
        //Number is : 4 and cube of the 4 is :64
        //Number is : 5 and cube of the 5 is :125
        public void CubeNum()
        {
            int givenNum;
            Console.WriteLine("Enter integer number");
            givenNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < givenNum; i++)
            {
                Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i * i * i));
            }

        }
        #endregion
    }
}
