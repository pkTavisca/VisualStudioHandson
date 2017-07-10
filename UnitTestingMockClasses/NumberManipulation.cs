using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMockClasses
{
    public class NumberManipulation
    {
        public int Factorial(int num)
        {
            if (num <= 1) return 1;
            return num * Factorial(num - 1);
        }

        public int Reverse(int num)
        {
            int reverse = 0;
            while (num > 0)
            {
                int rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            return reverse;
        }

        public int NoOfDigits(int num)
        {
            return (int)Math.Log10(num) + 1;
        }

        public int SumOfDigits(int num)
        {
            if (NoOfDigits(num) == 1) return num;
            int sumOfDigits = 0;
            for (int i = 0; num > 0; i++)
            {
                sumOfDigits += num % 10;
                num /= 10;
            }
            return SumOfDigits(sumOfDigits);
        }

        public bool IsMagicNo(int num)
        {
            return SumOfDigits(num) == 1;
        }
    }
}
