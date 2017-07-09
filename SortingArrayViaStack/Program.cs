using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackImplementation;

namespace SortingArrayViaStack
{
    class Program
    {
        static int[] arr = { 3, 5, 8, 3, 5, 2, 9, 4 };
        static Stack stack = new Stack();

        static void Main(string[] args)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                findMin(i);
                arr[stack.Pop()] = arr[i];
                arr[i] = stack.Pop();
                Console.Write(arr[i]+" ");
            }

            Console.ReadKey(true);
        }

        private static void findMin(int i)
        {
            int min = arr[i], minIndex = i ;
            for(int j = i; j < arr.Length; j++)
            {
                if (min > arr[j])
                {
                    min = arr[j];
                    minIndex = j;
                }

            }
            stack.Push(min);
            stack.Push(minIndex);
        }
    }
}
