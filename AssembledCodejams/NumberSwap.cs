using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class NumberSwap
    {
        public static void SwapNumber()
        {
            int a = 20;
            int b = 10;
            Console.WriteLine("Original Numbers: {0},{1}", a, b);
            SwapNumber(ref a, ref b);
            Console.WriteLine("New Numbers: {0},{1}", a, b);
        }

        private static void SwapNumber(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
