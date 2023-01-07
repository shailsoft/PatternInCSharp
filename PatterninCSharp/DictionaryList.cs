using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PatterninCSharp
{
    internal class DictionaryList
    {
        public void DictonaryHash()
        {
           
            // hashtable don't maintain the order 
            // it it come from using System.Collections.Generic;
            Dictionary<string, string> objDict = new Dictionary<string, string>();
            objDict.Add("a1", "C");
            objDict.Add("b2", "C++");
            objDict.Add("a3", "C#");
            objDict.Add("b1", "Net");


            foreach (KeyValuePair<string, string> element in objDict)
            {
                Console.WriteLine("Key:- {0} and values:- {1}", element.Key,element.Value);
            }
            // hashtable don't maintain the order 
            // it it come from using System.Collections;
            Hashtable hashtable = new Hashtable();
            hashtable.Add("A1", "Welcome");
            hashtable.Add("A2", 1);
            hashtable.Add("A3", "Shailendra Kumar"); 

            foreach (DictionaryEntry elem in hashtable)
            {
                Console.WriteLine("Key:- {0} and values:- {1}", elem.Key, elem.Value);
            }
            #region 1
            IDictionary<int, int> d = new Dictionary<int, int>();
            d.Add(1, 97);
            d.Add(2, 89);
            d.Add(3, 77);
            d.Add(4, 88);

            // Dictionary elements 
            #endregion
            Console.WriteLine("Dictionaly elements: " + d.Count);
        }
    }
}
