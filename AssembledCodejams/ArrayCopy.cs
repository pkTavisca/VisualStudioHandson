using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class ArrayCopy
    {
        public static int[] CopyArrayElements(int[] arr)
        {
            int[] arrCopy = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrCopy[i] = arr[i];
            }
            return arrCopy;
        }
        public static void CopyArrayElements()
        {
            int[] arr = { 1, 2, 3 };
            PrintArray(CopyArrayElements(arr));
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
