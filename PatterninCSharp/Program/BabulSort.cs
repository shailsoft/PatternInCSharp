using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Program
{
    public static class BabulSort
    {
        public static void SortData()
        {
            int[] adata = { 12, 13, 2, -3, -12, 8, 15, 1, 6, 4, 8, 9 };
            // result -12,-3,1,2,4,6,8,8,9,12,13,15,
            Console.WriteLine(adata);
            int swapNum = 0;

            for (int i = 0; i < adata.Length; i++)
            {
                for (int j = i + 1; j < adata.Length; j++)
                {

                    if (adata[i] > adata[j])
                    {
                        swapNum = adata[j];
                        adata[j] = adata[i];
                        adata[i] = swapNum;
                    }
                }
                Console.Write(adata[i] + ",");
            }

        }
        public static void ShortingString()
        {
            string str = "this is a string";
            // result = a g h i i i n r s s s t t 
            char[] arr1 = str.ToCharArray(0, str.Length);
            char ch;

            for (int i = 1; i < str.Length; i++)
                for (int j = 0; j < str.Length - i; j++)

                    if (arr1[j] > arr1[j + 1])
                    {
                        ch = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = ch;
                    }
            Console.Write("After sorting the string appears like : \n");
            foreach (char c in arr1)
            {
                ch = c;
                Console.Write("{0} ", ch);
            }
            Console.WriteLine("\n");
        }
    }
}
