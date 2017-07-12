using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Codejam
{
    class InverseFactoring
    {
        public int GetTheNumber(int[] factors)
        {
            int max = factors[0];
            int min = max;
            for (int i = 0; i < factors.Length; i++)
            {
                if (min > factors[i])
                {
                    min = factors[i];
                }
                if (max < factors[i])
                {
                    max = factors[i];
                }
            }
            return min * max;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            InverseFactoring inverseFactoring = new InverseFactoring();
            do
            {
                Thread th = new Thread(() =>
                {
                    try
                    {

                        string[] values = input.Split(',');
                        int[] factors = Array.ConvertAll<string, int>(values, delegate (string s) { return Int32.Parse(s); });
                        int validationOp = inverseFactoring.GetTheNumber(factors);
                        Console.WriteLine(validationOp);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception Occured" + ex.ToString());
                    }
                });
                th.Start();
                if (th.Join(1000) == false)
                {
                    Console.WriteLine("Timeout occured");
                    th.Abort();
                    return;
                }
                input = Console.ReadLine();

            } while (input != "-1");
        }

        #endregion
    }
}