using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp
{
    public class FibonacciSeries
    {
        // Write a program in C# Sharp to display the first n terms of Fibonacci series. The series is as follows : 
        //Fibonacci series 0 1 2 3 5 8 13 
        public static void Fibonacciseries()
        {
            int prv = 0, pre = 1, trm, i, inputNumber;

            Console.WriteLine("Display the first n terms of fibonacci series:\n ------------------------------------------------\n\n");
            Console.Write("Input number of terms to be display : ");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Here is the fibonacci series upto  to {0} terms : \n", inputNumber);
            Console.Write("{0}    {1}", prv, pre);
            for (i = 3; i <= inputNumber; i++)
            {
                trm = prv + pre;
                Console.Write("  {0}  ", trm);
                prv = pre;
                pre = trm;
            }
            Console.Write("\n");
        }
    }
}
