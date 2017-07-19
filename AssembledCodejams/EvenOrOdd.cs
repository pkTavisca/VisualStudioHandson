using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class EvenOrOdd
    {
        public static void FindEvenOrOdd()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            string evenOrOdd = num % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(evenOrOdd);
        }
    }
}
