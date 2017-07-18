using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Codejam
{
    class StandInLine
    {
        ArrayList solutions;
        int[] Reconstruct(int[] left)
        {
            solutions = new ArrayList();
            int[] finalPosition = new int[left.Length];
            findPermutations(left, finalPosition, 0);

            return FindRightSolution(left);
        }

        private int[] FindRightSolution(int[] highOnLeft)
        {
            foreach (int[] entry in solutions)
            {
                bool isValid = true;
                for (int i = 0; i < entry.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < i; j++)
                    {
                        if (entry[j]>entry[i])
                        {
                            count++;
                        }
                    }
                    if (highOnLeft[entry[i] - 1] != count)
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid) return entry;
            }
            return null;
        }

        private void findPermutations(int[] highOnLeft, int[] finalPosition, int index)
        {
            if (index >= finalPosition.Length)
            {
                solutions.Add(finalPosition);
                return;
            }
            for (int i = highOnLeft[index]; i < finalPosition.Length; i++)
            {
                if (finalPosition[i] == 0)
                {
                    if (IsViablePosition(index + 1, i, highOnLeft[index], finalPosition))
                    {
                        int[] temp = (int[])finalPosition.Clone();
                        temp[i] = index + 1;
                        findPermutations(highOnLeft, temp, index + 1);
                    }
                }
            }
        }

        private bool IsViablePosition(int soldierNo, int positionOfSoldier, int noOfbiggerOnLeft, int[] finalPosition)
        {
            int countBigger = noOfbiggerOnLeft;
            for (int i = positionOfSoldier + 1; i < finalPosition.Length; i++)
            {
                if (finalPosition[i] > soldierNo)
                    countBigger++;
                if (countBigger > finalPosition.Length - soldierNo)
                    return false;
            }
            return true;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            StandInLine standInLine = new StandInLine();
            do
            {
                int[] left = Array.ConvertAll<string, int>(input.Split(','), delegate (string s) { return Int32.Parse(s); });
                Console.WriteLine(string.Join(",", Array.ConvertAll<int, string>(standInLine.Reconstruct(left), delegate (int s) { return s.ToString(); })));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}
