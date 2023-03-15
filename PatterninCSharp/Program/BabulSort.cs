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
            // result 
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
    }
}
