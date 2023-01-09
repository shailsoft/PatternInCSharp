using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp
{
    public static class SwappingTwoNumbers
    {
        public static void SwappingTwoNoWithoutThirdVariable()
        {
            int a = 20;
            int b = 30;
            Console.WriteLine("Previous Value a = " + a);
            Console.WriteLine("Previous Value b = " + b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After Swap a  = " + a);
            Console.WriteLine("After Swap b = " + b);
        }
        public static void SwappingTwoNoWithoutThirdVariable1()
        {
            int a = 20;
            int b = 30;
            Console.WriteLine("Previous Value a = " + a);
            Console.WriteLine("Previous Value b = " + b);

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After Swap a  = " + a);
            Console.WriteLine("After Swap b = " + b);
        }
    }
}
