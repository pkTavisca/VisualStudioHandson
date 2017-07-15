using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace CodeJam
{
    public class EngineersPrimes
    {
        long SmallestNonPrime(int n)
        {
            n++;
            ArrayList primes = new ArrayList();
            primes.Add(2);
            int noOfPrimesFound = 1;
            int num = 3;
            while (noOfPrimesFound < n)
            {
                if (IsPrime(num, primes))
                {
                    primes.Add(num);
                    noOfPrimesFound++;
                }
                num++;
            }
            int last = (int)primes[primes.Count - 1];
            return (long)last * last;
        }

        private bool IsPrime(int num, ArrayList primes)
        {
            double sqrt = Math.Sqrt(num);
            foreach (int n in primes)
            {
                if (n > sqrt) break;
                if (num % n == 0) return false;
            }
            return true;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            EngineersPrimes engineersPrimes = new EngineersPrimes();
            String input = Console.ReadLine();
            do
            {
                Console.WriteLine(engineersPrimes.SmallestNonPrime(Int32.Parse(input)));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}