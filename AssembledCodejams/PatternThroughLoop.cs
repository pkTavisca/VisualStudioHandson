using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class PatternThroughLoop
    {
        public static void GeneratePattern()
        {
            GeneratePattern(5);
        }

        public static void GeneratePattern(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = num - i - 2; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(j + 1);
                }
                for (int j = i; j > 0; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
