using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Opps
{
    public class MethodOverload
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Arguments: " + a + " and " + b);
        }
        public new string Add(int a, string b)
        {
            Console.WriteLine("string wali: " + a + " and " + b);
            return b;
        }
    }
}