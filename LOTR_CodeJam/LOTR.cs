using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace CodeJam
{
    class LOTR
    {
        int GetMinimum(int[] replies)
        {
            int minPeople = 0;
            Dictionary<int, int> heightGrouper = new Dictionary<int, int>();
            for (int i = 0; i < replies.Length; i++)
            {
                if (heightGrouper.ContainsKey(replies[i]))
                {
                    heightGrouper[replies[i]]++;
                }
                else
                {
                    heightGrouper.Add(replies[i], 1);
                }
            }
            foreach (KeyValuePair<int, int> entry in heightGrouper)
            {
                minPeople += (entry.Key + 1) * (int)Math.Ceiling(entry.Value / (double)(entry.Key + 1));
            }
            return minPeople;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            LOTR lotr = new LOTR();
            String input = Console.ReadLine();
            do
            {
                int[] replies = Array.ConvertAll<string, int>(input.Split(','), delegate (string s) { return Int32.Parse(s); });
                Console.WriteLine(lotr.GetMinimum(replies));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion

    }
}
