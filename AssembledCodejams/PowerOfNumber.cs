using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class PowerOfNumber
    {
        public static void RaiseNumberToPower()
        {
            Console.Write("Enter a number: ");
            int num;
            int.TryParse(Console.ReadLine(), out num);

            Console.Write("Enter a power: ");
            int power;
            int.TryParse(Console.ReadLine(), out power);

            Console.WriteLine("Number {0} raised to the power {1} is {2}.", num, power, Math.Pow(num, power));
        }
    }
}
