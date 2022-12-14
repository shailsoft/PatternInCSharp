using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp
{
    public class StringAndStringBuilder
    {
        public static void String()
        {
            // string are immutable
            // string can not be change once created
            string s1 = "String";
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                s1 = s1 + i;
            }
            sw.Stop();
            Console.WriteLine("String taken total time : " + sw.ElapsedMilliseconds);
        }
        public static void StringBuilders()
        {
            // string builder a dynamic object that allow to you spend that nimber of charctor in string
            // does not create new memory but dynamiccaly expend memory
            StringBuilder sb = new StringBuilder("StringBuilder");
            Stopwatch sw2 = Stopwatch.StartNew();
            sw2.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("String Builder taken total time : " + sw2.ElapsedMilliseconds);
        }
    }
}
