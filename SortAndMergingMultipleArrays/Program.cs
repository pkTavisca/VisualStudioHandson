using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndMergingMultipleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] inputData = InputInititalData();

            int[] merged = Merge(inputData);

            merged = MergeSort(merged);

            ArrayDisplay(merged);

            Console.ReadKey();

        }

        private static void ArrayDisplay(int[] merged)
        {
            Console.Write("[");
            for (int i = 0; i < merged.Length; i++)
            {
                Console.Write(merged[i] + " ");
            }
            Console.WriteLine("]");
        }

        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length == 1) return arr;
            int middle = (arr.Length - 1) / 2;
            int[] left = new int[middle + 1];
            int[] right = new int[arr.Length - middle - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < left.Length)
                {
                    left[i] = arr[i];
                }
                else
                {
                    right[i % left.Length] = arr[i];
                }
            }
            int[] leftSorted = MergeSort(left);
            int[] rightSorted = MergeSort(right);
            int[][] toBeMerged = new int[2][];
            toBeMerged[0] = leftSorted;
            toBeMerged[1] = rightSorted;
            return Merge(toBeMerged);
        }

        private static int[] Merge(int[][] toBeMerged)
        {
            for (int i = 1; i < toBeMerged.Length; i++)
            {
                toBeMerged[0] = Merge(toBeMerged[0], toBeMerged[i]);
            }
            return toBeMerged[0];
        }

        public static int[] Merge(int[] arr1, int[] arr2)
        {
            int totalSize = arr1.Length + arr2.Length;
            int index1 = 0, index2 = 0;
            int[] merged = new int[totalSize];
            for (int i = 0; i < totalSize; i++)
            {
                if (index1 >= arr1.Length)
                {
                    merged[i] = arr2[index2++];
                }
                else if (index2 >= arr2.Length)
                {
                    merged[i] = arr1[index1++];
                }
                else if (arr1[index1] > arr2[index2])
                {
                    merged[i] = arr2[index2++];
                }
                else
                {
                    merged[i] = arr1[index1++];
                }
            }
            return merged;
        }

        public static int[][] InputInititalData()
        {
            Console.Write("Enter the number of arrays ");
            int numOfArr = int.Parse(Console.ReadLine());

            int[][] input = new int[numOfArr][];

            for (int i = 0; i < numOfArr; i++)
            {
                Console.WriteLine("Enter array {0} separated by space: ", i + 1);
                string[] tempArrInString = (Console.ReadLine()).Split();
                input[i] = new int[tempArrInString.Length];
                for (int j = 0; j < tempArrInString.Length; j++)
                {
                    input[i][j] = int.Parse(tempArrInString[j]);
                }
            }
            return input;
        }
    }
}
