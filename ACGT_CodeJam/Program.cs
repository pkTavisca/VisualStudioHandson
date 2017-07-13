using System;
using System.Collections.Generic;

namespace CodeJam
{
    class ACGT
    {
        int MinChanges(int maxPeriod, string[] acgt)
        {
            string combined = "";
            for (int i = 0; i < acgt.Length; i++)
            {
                combined += acgt[i];
            }
            int[] changesInAllPeriods = new int[maxPeriod];
            for (int period = 1; period <= maxPeriod; period++)
            {
                int changesForPeriod = 0;
                for (int posInPeriod = 0; posInPeriod < period; posInPeriod++)
                {
                    Dictionary<char, int> charMap = new Dictionary<char, int>();
                    for (int charMapper = posInPeriod; charMapper < combined.Length; charMapper += period)
                    {
                        if (charMap.ContainsKey(combined[charMapper]))
                        {
                            charMap[combined[charMapper]]++;
                        }
                        else
                        {
                            charMap.Add(combined[charMapper],1);
                        }
                    }
                    changesForPeriod += TotalMinusMax(charMap);
                }
                changesInAllPeriods[period - 1] = changesForPeriod;
            }
            return MinInArray(changesInAllPeriods);
        }

        private int TotalMinusMax(Dictionary<char, int> charMap)
        {
            int total = 0;
            var enumerator = charMap.GetEnumerator();
            enumerator.MoveNext();
            int max = enumerator.Current.Value;
            foreach (KeyValuePair< char, int> entry in charMap)
            {
                if (entry.Value > max)
                    max = entry.Value;
                total += entry.Value;
            }
            return total - max;
        }

        int MinInArray(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            ACGT aCGT = new ACGT();
            String input = Console.ReadLine();
            do
            {
                var inputParts = input.Split('|');
                int maxPeriod = int.Parse(inputParts[0]);
                string[] acgt = inputParts[1].Split(',');
                Console.WriteLine(aCGT.MinChanges(maxPeriod, acgt));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}