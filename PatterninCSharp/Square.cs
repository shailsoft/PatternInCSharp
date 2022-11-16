using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp
{
    public static class Square
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
            Console.ReadLine();
        }
    }
}
