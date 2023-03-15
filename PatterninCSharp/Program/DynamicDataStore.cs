using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Program
{
    public static class DynamicDataStore
    {
        public static void DynamicValues(int Id)
        {
            Dictionary<string, object> values = new Dictionary<string, object>();
            List<string> list = new List<string> {
             "Shailendra",
             "Shailendra",
             "Shailendra1"
        };
            object objj = new object();
            string dataaaa = "djhdkjfgkdf dfuisgfb snfcjsd fsnjfvdhs";

            string name = "";

            if (1 != Id)
            {
                objj = Id;
                values.Add("Result", Convert.ToString(Id));
            }
            else if (1 != Id)
            {
                objj = list;
                values.Add("Result", list);
            }
            else
            {
                objj = list;
                values.Add("Result", dataaaa);
            }

        }

    }
}
