using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTR_CodeJam
{
    class Program
    {

        static int GetMinimum(int[] replies)
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

        static void Main(string[] args)
        {
            int[] replies = { 2, 2, 44, 2, 2, 2, 444, 2, 2 };
            Console.WriteLine(GetMinimum(replies));
            Console.ReadKey();
        }
    }
}
