using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class StringReverse
    {
        public static void ReverseString()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            Console.Write("Reversed String :  ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[str.Length - 1 - i]);
            }
        }
    }
}
