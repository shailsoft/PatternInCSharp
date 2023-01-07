using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
