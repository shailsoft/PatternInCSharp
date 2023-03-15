using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Program
{
    public static class Square
    {
        public static void SquarePrint()
        {

            for (int row = 1; row <= 10; row++)
            {
                for (int col = 1; col <= 10; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            //int row, col;
            //for (row = 1; row <= 10; row++)
            //{
            //    for (col = 1; col <= 10; col++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadLine();
        }
    }
}
