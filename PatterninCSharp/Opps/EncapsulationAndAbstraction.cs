using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PatterninCSharp.Opps
{
    public class EncapsulationAndAbstraction
    {
        #region Encapsulation
        #region What is encapsulation in OOP?
        //Encapsulation in object-oriented programming(OOP) is a mechanism of hiding the
        //internal details(implementation) of an object from other objects and the
        //outside world.It is one of the four fundamental principles of OOP
        #endregion

        #region Why do we need encapsulation?
        //Encapsulation is an important concept in object-oriented programming(OOP)
        //because it allows you to hide the internal details(implementation) of an object
        //from other objects and the outside world.
        #endregion

        public class BankAccount
        {
            private decimal balance;
            public BankAccount(decimal initialBalance)
            {
                balance = initialBalance;
            }
            public void Deposit(decimal amount)
            {
                balance += amount;
            }
            public void Withdraw(decimal amount)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }

            public decimal GetBalance() { return balance; }
        }

        //static void Main(string[] args)
        //{
        //    BankAccount myAccount = new BankAccount(1000);

        //    myAccount.Deposit(500);
        //    Console.WriteLine("Balance: "
        //                    + myAccount.GetBalance());

        //    myAccount.Withdraw(1200);
        //    Console.WriteLine("Balance: "
        //                    + myAccount.GetBalance());
        //}
        #endregion
        #region Encapsulation 2 example
        class Car
        {
            private int _speed;
            public int Speed
            {
                get { return _speed; }
                set { _speed = value; }
            }
        }
        #region 
        //In this example, the private field "_speed" is encapsulated by
        //the public property "Speed." The "get" accessor of the property allows
        //other objects to retrieve the value of the private field, while the "set"
        //accessor allows them to modify it.
        #endregion
        #endregion

        #region Abstraction

        #endregion

    }
}
