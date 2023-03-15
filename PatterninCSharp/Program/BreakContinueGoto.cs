using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Program
{
    public static class BreakContinueGoto
    {
        public static void Break()
        {
            // {{break}}use this always use in side loop
            // Result: 1, 2, 3, 4
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.Write(i + ", ");
            }
        }

        public static void Continue()
        {
            // {{continue}} this is skip the conditional
            // Result:  1, 2, 3, 4, 6, 7, 8, 9, 10
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.Write(i + ", ");
            }
        }

        public static void Goto()
        {
            // {{Goto}} this is use call again
            // Result:  1, 2, 3, 4, 6, 7, 8, 9, 10 and next answer : this is got methos
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    goto CallAgainDown;
                }
                Console.Write(i + ", ");
            }
            Console.WriteLine("skip this methos");
        CallAgainDown:
            Console.WriteLine("this is got methos");
        }
    }
}
