using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Opps
{
    public class Inheritance
    {
        #region Single Inheritance
        // It is the type of inheritance in which there is one base class and one derived class.
        public class SingleInhBase //base class
        {
            public string Credit()
            {
                return "balance is credited";
            }
        }
        public class SingleInhDerived : SingleInhBase //derived class
        {
            public string debit()
            {
                Credit();                       ////derived class method
                return "balance is debited";
            }
        }
        #endregion

        #region Hierarchical inheritance
        // This is the type of inheritance in which there are multiple classes derived from one base class. This type of inheritance is used when there is a requirement of one class feature that is needed in multiple classes.
        class A  //base class
        {
            public string msg()
            {
                return "this is A class Method";
            }
        }
        class B : A
        {
            public string info()
            {
                msg();
                return "this is B class Method";
            }
            class C : A
            {
                public string getinfo()
                {
                    msg();
                    return "this is B class Method";
                }
            }
        }
        #endregion

        #region Multilevel inheritance
        // When one class is derived from another, this type of inheritance is called multilevel inheritance.
        public class Person
        {
            public string persondet()
            {
                return "this is the person class";
            }
        }
        public class Bird : Person
        {
            public string birddet()
            {
                persondet();
                return "this is the birddet Class";
            }
        }
        public class Animal : Bird
        {
            public string animaldet()
            {
                persondet();
                birddet();
                return "this is the Animal Class";
            }
        }
        #endregion

        #region Multiple inheritances using Interfaces
        // C# does not support multiple inheritances of classes. To overcome this problem, we can use interfaces.
        public interface IA //ineterface  1
        {
            string setImgs(string a);
        }
        public interface IB  //Interface 2
        {
            int getAmount(int Amt);
        }
        public class ICar : IA, IB //implementatin
        {
            public int getAmount(int Amt)
            {
                return 100;
            }
            public string setImgs(string a)
            {
                return "this is the car";
            }
        }
        #endregion
    }
}
