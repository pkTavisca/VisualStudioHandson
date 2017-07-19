using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class TaxCalculation
    {
        public static void CalculateTax()
        {
            Console.Write("Enter the money: ");
            int money = int.Parse(Console.ReadLine());
            double tax = 0;
            if (money < 10000) tax = money * 5.0 / 100;
            else if (money < 100000) tax = money * 8.0 / 100;
            else tax = money * 8.5 / 100;

            Console.WriteLine("The tax is " + tax);
        }
    }
}
