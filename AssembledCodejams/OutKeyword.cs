using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class OutKeyword
    {
        public static void UseOutKeyword()
        {
            int[] arr = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter number {0}:", i + 1);
                int.TryParse(Console.ReadLine(), out arr[i]);
            }

            int add, substract, multiply;

            Add(arr, out add);
            Substract(arr, out substract);
            Multiply(arr, out multiply);

            Console.WriteLine("Addition : " + add);
            Console.WriteLine("Substraction : " + substract);
            Console.WriteLine("Multiplication : " + multiply);
        }

        public static void Add(int[] arr, out int res)
        {
            res = arr[0] + arr[1] + arr[2] + arr[3];
        }
        public static void Substract(int[] arr, out int res)
        {
            res = arr[0] - arr[1] - arr[2] - arr[3];
        }
        public static void Multiply(int[] arr, out int res)
        {
            res = arr[0] * arr[1] * arr[2] * arr[3];
        }
    }
}
