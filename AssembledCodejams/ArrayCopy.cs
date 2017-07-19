using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class ArrayCopy
    {
        public static void CopyArrayElements(int[] arr)
        {
            int[] arrCopy = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrCopy[i] = arr[i];
                Console.Write(arrCopy[i] + " ");
            }
        }
        public static void CopyArrayElements()
        {
            int[] arr = { 1, 2, 3 };
            CopyArrayElements(arr);
        }
    }
}
