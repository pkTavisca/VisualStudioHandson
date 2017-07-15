using System;
using System.Collections.Generic;
using System.Text;


namespace Codejam
{
    class TriFibonacci
    {
        public int Complete(int[] arr)
        {
            int missingIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == -1)
                {
                    missingIndex = i;
                    break;
                }
                if (i > 2)
                {
                    if (arr[i] != arr[i - 3] + arr[i - 2] + arr[i - 1])
                        return -1;
                }
            }
            if (missingIndex > 2)
            {
                arr[missingIndex] = arr[missingIndex - 3] + arr[missingIndex - 2] + arr[missingIndex - 1];
            }
            else
            {
                arr[missingIndex] = arr[3] - (arr[0] + arr[1] + arr[2] + 1);
            }
            if (arr[missingIndex] < 1) return -1;
            for (int i = missingIndex > 2 ? missingIndex : 3; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 3] + arr[i - 2] + arr[i - 1])
                    return -1;
            }
            return arr[missingIndex];
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            TriFibonacci triFibonacci = new TriFibonacci();
            do
            {
                string[] values = input.Split(',');
                int[] numbers = Array.ConvertAll<string, int>(values, delegate (string s) { return Int32.Parse(s); });
                int result = triFibonacci.Complete(numbers);
                Console.WriteLine(result);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}