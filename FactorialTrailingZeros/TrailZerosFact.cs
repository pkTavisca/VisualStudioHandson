using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTrailingZeros
{
    public class TrailZerosFact
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int numInBase = int.Parse(Console.ReadLine());

            while (numInBase < 0)
            {
                Console.Write("Please enter a positive number : ");
                numInBase = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the base: ");
            int Base = int.Parse(Console.ReadLine());

            while (Base < 1)
            {
                Console.Write("Please enter a base more than 0 : ");
                Base = int.Parse(Console.ReadLine());
            }

            Console.Write("The total number of zeros in the factorial of the number in base format = ");
            Console.WriteLine(FindNoOfZerosInFactorialInBase(numInBase, Base));

            Console.ReadKey(true);
        }

        public static int FindNoOfZerosInFactorialInBase(int numInBase, int Base)
        {
            if (Base == 1) return Factorial(numInBase);
            if (numInBase < 1) return 0;
            int num = ConvertToBase10(numInBase, Base);
            Dictionary<int, int> numFactorialFactors = GetTotalFactorsWithBaseTill(num, Base);
            Dictionary<int, int> baseFactors = GetPrimeFactorsOfNo(Base);

            int minOfTheFactors = num;
            foreach (KeyValuePair<int, int> entry in baseFactors)
            {
                int noOfFactorGroup = numFactorialFactors[entry.Key] / entry.Value;
                if (noOfFactorGroup < minOfTheFactors)
                {
                    minOfTheFactors = noOfFactorGroup;
                }
            }
            return minOfTheFactors;
        }

        public static Dictionary<int, int> GetTotalFactorsWithBaseTill(int num, int Base)
        {
            Dictionary<int, int> totalPrimeFactorsInFactorial = new Dictionary<int, int>();
            for (int i = 2; i <= num; i++)
            {
                Dictionary<int, int> factorsOfNum = GetPrimeFactorsOfNoWithBase(i, Base);
                foreach (KeyValuePair<int, int> entry in factorsOfNum)
                {
                    if (totalPrimeFactorsInFactorial.ContainsKey(entry.Key))
                    {
                        totalPrimeFactorsInFactorial[entry.Key] += entry.Value;
                    }
                    else
                    {
                        totalPrimeFactorsInFactorial[entry.Key] = entry.Value;
                    }
                }
            }
            return totalPrimeFactorsInFactorial;
        }

        public static Dictionary<int, int> GetPrimeFactorsOfNoWithBase(int num, int Base)
        {
            Dictionary<int, int> primeFactorsMap = new Dictionary<int, int>();
            ArrayList primeFactors = GetAllPrimeNosTill(num);
            Dictionary<int, int> primeFactorsOfBase = GetPrimeFactorsOfNo(Base);
            foreach (int i in primeFactors)
            {
                if (!primeFactorsOfBase.ContainsKey(i))
                    continue;
                while (num % i == 0)
                {
                    if (primeFactorsMap.ContainsKey(i))
                    {
                        int temp;
                        primeFactorsMap.TryGetValue(i, out temp);
                        primeFactorsMap[i] = temp + 1;
                    }
                    else
                    {
                        primeFactorsMap.Add(i, 1);
                    }
                    num /= i;
                }
            }
            return primeFactorsMap;
        }

        public static Dictionary<int, int> GetPrimeFactorsOfNo(int num)
        {
            Dictionary<int, int> primeFactorsMap = new Dictionary<int, int>();
            ArrayList primeFactors = GetAllPrimeNosTill(num);
            foreach (int i in primeFactors)
            {
                while (num % i == 0)
                {
                    if (primeFactorsMap.ContainsKey(i))
                    {
                        int temp;
                        primeFactorsMap.TryGetValue(i, out temp);
                        primeFactorsMap[i] = temp + 1;
                    }
                    else
                    {
                        primeFactorsMap.Add(i, 1);
                    }
                    num /= i;
                }
            }
            return primeFactorsMap;
        }

        public static ArrayList GetAllPrimeNosTill(int num)
        {
            ArrayList primeNos = new ArrayList();
            for (int i = 1; i < num; i++)
            {
                primeNos.Add(i + 1);
            }
            for (int i = 0; i < primeNos.Count; i++)
            {
                for (int j = i + 1; j < primeNos.Count; j++)
                {
                    if ((int)(primeNos[j]) % (int)(primeNos[i]) == 0)
                    {
                        primeNos.RemoveAt(j--);
                    }
                }
            }
            return primeNos;
        }

        public static int ConvertFromBase10(int num, int Base)
        {
            int converted = 0;
            int nod = NoOfDigits(num);
            for (int i = 0; num > 0; i++)
            {
                int remainder = num % Base;
                converted += remainder * (int)Math.Pow(10, i);
                num /= Base;
            }
            return converted;
        }

        public static int ConvertToBase10(int num, int Base)
        {
            int num10 = 0;
            for (int i = 0; i < (int)Math.Log10(num) + 1; i++)
            {
                num10 += ((num / (int)Math.Pow(10, i)) % 10) * (int)Math.Pow(Base, i);
            }
            return num10;
        }

        public static int NoOfDigits(int num)
        {
            return (int)Math.Log10(num) + 1;
        }

        public static int Factorial(int num)
        {
            if (num == 1 || num == 0) return 1;
            return num * Factorial(num - 1);
        }
    }
}
