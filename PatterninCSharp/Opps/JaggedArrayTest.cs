using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterninCSharp.Opps
{
    public static class JaggedArrayTest
    {
        public static void JaggedArry()
        {
            int[][] jArr = new int[2][];// Declare the array  

            jArr[0] = new int[] { 1, 21, 56, 78 };// Initialize the array          
            jArr[1] = new int[] { 42, 61, 37, 41, 59, 63 };

            // Traverse array elements  
            for (int i = 0; i < jArr.Length; i++)
            {
                for (int j = 0; j < jArr[i].Length; j++)
                {
                    System.Console.Write(jArr[i][j] + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
