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
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            Console.Write("Reversed String : {0}", ReverseString(str));

        }

        public static string ReverseString(string str)
        {
            string reversed = String.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                reversed += str[str.Length - 1 - i];
            }
            return reversed;
        }
    }
}
