using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Opps
{
    public sealed class SingletonPattern
    {
        private SingletonPattern()
        {
        }
        private static SingletonPattern? _instance = null;

        private static readonly object lockObj = new object();
        public static SingletonPattern GetInstance()
        {
            lock (lockObj)
            {
                if (_instance == null)
                {
                    Console.WriteLine("single instance");
                    _instance = new SingletonPattern();
                }
            }
            return _instance;
        }
        //public class OtherClass : SingletonPattern
        //{
        //}
    }
}
