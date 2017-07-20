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
            decimal money;
            decimal.TryParse(Console.ReadLine(), out money);
            decimal tax = 0;

            if (money < 10000) tax = Decimal.Multiply(money, Convert.ToDecimal(0.05));
            else if (money < 100000) tax = Decimal.Multiply(money, Convert.ToDecimal(0.08));
            else tax = Decimal.Multiply(money, Convert.ToDecimal(0.085));

            Console.WriteLine("The tax is " + tax);
        }
    }
}
