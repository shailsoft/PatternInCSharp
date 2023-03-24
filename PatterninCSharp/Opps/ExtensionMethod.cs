using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Opps
{
    public static class ExtensionMethod
    {
        // return type we can not use void but we can use any types of return type 
        public static int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public static int AddExtension(this int addMthodResult)
        {
            int c = addMthodResult * 10;
            return c;
        }

    }
}
