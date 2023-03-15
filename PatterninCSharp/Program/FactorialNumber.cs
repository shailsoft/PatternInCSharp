using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Program
{
    public class FactorialNumber
    {
        public static void FactorialGivenNumber()
        {
            int i, fact = 1, inputNumber;

            Console.Write("\n\n");
            Console.Write("Calculate the factorial of a given number:\n--------------------------------------------\n\n");
            Console.Write("Input the number : ");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= inputNumber; i++)
                fact = fact * i;

            Console.Write("The Factorial of {0} is: {1}\n", inputNumber, fact);

        }

    }
}
