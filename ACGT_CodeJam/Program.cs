using System;

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
                int noOfChangesInPeriod = 0;
                int maxGroups = (int)(Math.Ceiling(combined.Length / (double)period));
                int[] noOfChangesInGroup = new int[maxGroups];
                for (int group = 0; group < maxGroups; group++)
                {
                    for (int inPeriodIndex = 0; inPeriodIndex < period && group * period + inPeriodIndex < combined.Length; inPeriodIndex++)
                    {
                        int currentPosition = inPeriodIndex;
                        while (currentPosition < combined.Length)
                        {
                            if (combined[currentPosition] != combined[period * group + inPeriodIndex])
                            {
                                noOfChangesInGroup[group]++;
                            }
                            currentPosition += period;
                        }
                    }
                }
                if (combined.Length % maxPeriod != 0) noOfChangesInGroup[maxGroups - 1] = noOfChangesInGroup[0];
                noOfChangesInPeriod = MinInArray(noOfChangesInGroup);
                changesInAllPeriods[period - 1] = noOfChangesInPeriod;
            }
            return MinInArray(changesInAllPeriods);
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