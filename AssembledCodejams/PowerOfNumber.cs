using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class PowerOfNumber
    {
        public static void PowerOfNum()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter a power: ");
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine("Power of the number is {0}", Math.Pow(num, power));
        }
    }
}
