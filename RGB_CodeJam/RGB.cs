using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class RGB
    {
        int GetLeast(string[] picture)
        {
            int totalLines = 0;

            bool[][] considered = new bool[picture.Length][];
            InitializeConsideredArray(ref considered);

            for (int i = 0; i < picture.Length; i++)
            {
                for (int j = 0; j < picture[i].Length; j++)
                {
                    if (picture[i][j] != '.' && !considered[i][j])
                        totalLines += Process(i, j, picture, ref considered);
                }
            }

            return totalLines;
        }

        private int Process(int x, int y, string[] picture, ref bool[][] considered)
        {
            int lines = 0;
            if (picture[x][y] == 'R')
            {

            }
            return 0;
        }

        private void InitializeConsideredArray(ref bool[][] considered)
        {
            for (int i = 0; i < considered.Length; i++)
            {
                considered[i] = new bool[considered.Length];
            }
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            RGB rgbSolver = new RGB();
            do
            {
                string[] picture = input.Split(',');
                Console.WriteLine(rgbSolver.GetLeast(picture));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}

