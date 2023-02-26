using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp
{
    public static class AllPattern
    {
        public static void SquarePrint()
        {
            int row, col;
            for (row = 1; row <= 10; row++)
            {
                for (col = 1; col <= 10; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void LeftLowerAngleTriangle()
        {
            int row, col;
            for (row = 1; row <= 10; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void LeftUpperAngleTriangle()
        {
            int row, col;
            for (row = 1; row <= 10; row++)
            {
                for (col = row; col < 10; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void RightLowerAngleTriangle()
        {
            int row, col, space;
            for (row = 1; row <= 10; row++)
            {
                for (space = row; space < 10; space++)
                {
                    Console.Write(" ");
                }
                for (col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void RightUpperAngleTriangle()
        {
            //
            int row, col, space;
            for (row = 1; row <= 10; row++)
            {
                for (space = row; space < 10; space++)
                {
                    Console.Write(" ");
                }
                for (col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //Write a program in C to display the pattern like a diamond.The pattern is as follows :
        public static void Diamond()
        {

            int row, col, inputNumber;
            Console.WriteLine("Display the pattern like diamond:\n-----------------------------------\n\n");
            Console.Write("Input number of rows (half of the diamond) :");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            for (row = 0; row <= inputNumber; row++)
            {
                for (col = 1; col <= inputNumber - row; col++)
                    Console.Write(" ");
                for (col = 1; col <= 2 * row - 1; col++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (row = inputNumber - 1; row >= 1; row--)
            {
                for (col = 1; col <= inputNumber - row; col++)
                    Console.Write(" ");
                for (col = 1; col <= 2 * row - 1; col++)
                    Console.Write("*");
                Console.Write("\n");
            }

            //result

            //        ***
            //       *****
            //      *******
            //     *********
            //    ***********
            //   *************
            //  ***************
            // *****************
            //*******************
            // *****************
            //  ***************
            //   *************
            //    ***********
            //     *********
            //      *******
            //       *****
            //        ***
            //         *
        }
        //Write a program in C# Sharp to display the pattern like a pyramid using asterisk and each row contain an odd number of asterisks.
        public static void PyramidUsingAsterisk()
        {
            int i, j, n;

            Console.Write("Display the pattern like pyramid containing odd number of asterisks:\n----------------------------------------\n\n");
            Console.Write("Input number of rows for this pattern :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            //result
            //         *
            //        ***
            //       *****
            //      *******
            //     *********
            //    ***********
            //   *************
            //  ***************
            // *****************

            //Display the pattern like diamond:
        }
        //Write a program in C# Sharp to make such a pattern like a pyramid with number which will repeat the number in the same row.The pattern is as follows:
        public static void PyramidWithNumber()
        {
            int i, j, spc, rows, k;

            Console.Write("Display the pattern like pyramid with repeating a number in same row:\n------------------------------------\n\n");
            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", i);
                Console.Write("\n");
                spc--;

            }

            //result
            //            Input number of rows : 10
            //             1
            //            2 2
            //           3 3 3
            //          4 4 4 4
            //         5 5 5 5 5
            //        6 6 6 6 6 6
            //       7 7 7 7 7 7 7
            //      8 8 8 8 8 8 8 8
            //     9 9 9 9 9 9 9 9 9
            //    10 10 10 10 10 10 10 10 10 10

            //Display the pattern like pyramid containing odd number of asterisks:
        }
        //Write a program in C# Sharp to display the first 10 natural numbers
        public static void NaturalNumbers()
        {

            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} ", i);
            }
            //result
            //            Input number of rows : 10
            // 1 2 3 4 5 6 7 8 9 10
        }
    }
}
