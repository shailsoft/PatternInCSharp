using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Opps
{
    public class MethodOverRiding
    {
        public virtual void Method1()
        {
            Console.WriteLine("Method override base1 ");
        }
        public virtual string Method2()
        {
            Console.WriteLine("Method override base 2");
            return "";
        }
    }
    public class MethodOverRidingDerivedClass : MethodOverRiding
    {
        public override void Method1()
        {
            Console.WriteLine("method overriding derived 1");
        }
        public new void Method2()
        {
            Console.WriteLine("method overriding derived 2");
        }
    }
}
