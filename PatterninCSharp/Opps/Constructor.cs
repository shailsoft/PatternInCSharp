using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Opps
{
    public class Constructor
    {
        public static int age;
        private Constructor()
        {

        }
        //public Constructor()
        //{
        //    Console.WriteLine("Default constructor invoked{0}", age);
        //}
        static Constructor()
        {
            Console.WriteLine("static constructor invoked{0}", age);
        }

        //public Constructor(int a)
        //{
        //    Console.WriteLine("Default constructor invoked {0}", a);
        //}
    }
}
