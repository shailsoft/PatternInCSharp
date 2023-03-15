using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Program
{
    public static class NullCoalescingOperator
    {
        public static void NullCoalseing()
        {
            string? Item1 = null;
            string? Item2 = "Banana";
            string? Item3 = "Apple";
            //string? Name = null;
            string? Res = Item1 ?? Item2 ?? Item3;
            Console.WriteLine(Res);

            /////////////
            string? Name = "Shailendra";
            //string? Name = null;
            string? Result = Name ?? "NA";

            // tarika dusra
            //string? Name = "Shailendra";
            //string? Result = string.Empty;
            ////if (Name != null)
            ////{
            ////    Result = Name;
            ////}
            Console.WriteLine(Result);
        }
    }
}
