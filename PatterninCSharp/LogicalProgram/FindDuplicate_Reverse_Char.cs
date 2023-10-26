

namespace PatterninCSharp.LogicalProgram
{
    public static class FindDuplicate_Reverse_Char
    {
        public static void ReverseString()
        {
            string str = "shailendra Kumar Bharti";
            //itrahB ramuK ardneliahs
            char[] chars = str.ToCharArray();

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                Console.Write(chars[i]);
            }

            Array.Reverse(chars);
            Console.Write(new string(chars));

        }
        public static void CountNoOfDuplicateCharGivenString()
        {
            string message = "shailendra kumar bharti";
            while (message.Length > 0)
            {
                Console.Write(message[0] + " : ");
                //  s: 1
                //  h: 1
                //  a: 3
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
        public static void SortingTheGivenString()
        {
            string str = "shailendra kumar bharti";
            Console.WriteLine(String.Concat(str.OrderBy(c => c)));


            string x = "ABCGH";
            char[] charX = x.ToCharArray();
            Array.Sort(charX);
            x = new string(charX);
            Console.WriteLine(x);
        }
        public static void ShortingStringWithoutInBuildFuction()
        {
            string str = "this is a string";
            // result = a g h i i i n r s s s t t 
            char[] arr1 = str.ToCharArray();
            char ch;

            for (int i = 1; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length - i; j++)
                {
                    if (arr1[j] > arr1[j + 1])
                    {
                        ch = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = ch;
                    }
                }
            }
            Console.Write("After sorting the string appears like : \n");
            foreach (char c in arr1)
            {
                ch = c;
                Console.Write("{0} ", ch);
            }
        }



        public static void SortingArray_OrderingWithInbuildFunction()
        {
            int[] numbers = { 4, 7, 2, 3, 4, 5, 3, 6, 7, 8, 1, 8 };
            Array.Sort(numbers);
            foreach (var chr in numbers)
            {
                Console.Write(chr + ",");
            }
        }
        public static void SortingArray_Ordering()
        {
            int[] arrayData = { 12, 13, 2, -3, -12, 8, 15, 1, 6, 4, 8, 9 };
            // result -12,-3,1,2,4,6,8,8,9,12,13,15,
            int swapNum = 0;
            for (int i = 0; i < arrayData.Length; i++)
            {
                for (int j = i + 1; j < arrayData.Length; j++)
                {
                    if (arrayData[i] > arrayData[j])
                    {
                        swapNum = arrayData[j];
                        arrayData[j] = arrayData[i];
                        arrayData[i] = swapNum;
                    }
                }
                Console.Write(arrayData[i] + ",");
            }
        }
        public static void FindDuplicateInIntArray()
        {

            int[] numbers1 = { 4, 7, 2, 3, 4, 5, 3, 6, 7, 8, 1, 8, 8 };
            int[] distinctNumbers1 = numbers1.Distinct().ToArray();
            int[] duplicateNumbers1 = numbers1.GroupBy(x => x).Where(g => g.Count() > 1)
                .Select(g => g.Key).ToArray();
            //////

            int[] numbers = { 4, 7, 2, 3, 4, 5, 6, 7, 8, 1, 8 };
            HashSet<int> distinctNumbers = new();
            HashSet<int> duplicateNumbers = new();

            foreach (int number in numbers)
            {
                if (!distinctNumbers.Add(number))
                    duplicateNumbers.Add(number);
            }

            Console.WriteLine("original array");
            PrintArray(numbers);

            Console.WriteLine("distinct Numbers");
            PrintArray(distinctNumbers.ToArray());

            Console.WriteLine("duplicate Numbers");
            PrintArray(duplicateNumbers.ToArray());

            Console.ReadLine();


           
        }
        static void PrintArray(int[] numArray)
        {
            foreach (int num in numArray)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
