using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Program
{
    public class CountCharFromString
    {
        public void CountCharGivenString()
        {
            string message = "shailendra kumar bharti";
            while (message.Length > 0)
            {
                Console.Write(message[0] + " : ");
                int count = 0;
                for (int j = 0; j < message.Length; j++)
                {
                    if (message[0] == message[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                message = message.Replace(message[0].ToString(), string.Empty);
            }
        }
    }
}
