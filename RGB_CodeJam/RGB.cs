using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class RGB
    {
        bool[][] consideredRed;
        bool[][] consideredBlue;
        string[] picture;
        int totalLines;
        int GetLeast(string[] picture)
        {
            totalLines = 0;
            consideredRed = new bool[picture.Length][];
            consideredBlue = new bool[picture.Length][];
            this.picture = picture;

            InitializeConsideredArray();

            for (int i = 0; i < picture.Length; i++)
            {
                for (int j = 0; j < picture[i].Length; j++)
                {
                    if (picture[i][j] != '.' && (!consideredRed[i][j] || !consideredBlue[i][j]))
                    {
                        Process(i, j);
                    }
                }
            }
            return totalLines;
        }

        private void Process(int y, int x)
        {
            if (picture[y][x] == 'R')
            {
                if (!consideredRed[y][x])
                    ProcessX(y, x);
            }
            else if (picture[y][x] == 'B')
            {
                if (!consideredBlue[y][x])
                    ProcessY(y, x);
            }
            else if (picture[y][x] == 'G')
            {
                if (!consideredRed[y][x])
                    ProcessX(y, x);
                if (!consideredBlue[y][x])
                    ProcessY(y, x);
            }
        }

        private void ProcessX(int y, int x)
        {
            totalLines++;
            for (int i = x; i >= 0; i--)
            {
                if (picture[y][i] == 'R' || picture[y][i] == 'G')
                {
                    consideredRed[y][i] = true;
                }
                else break;
            }
            for (int i = x + 1; i < picture[y].Length; i++)
            {
                if (picture[y][i] == 'R' || picture[y][i] == 'G')
                {
                    consideredRed[y][i] = true;
                }
                else break;
            }
        }

        private void ProcessY(int y, int x)
        {
            totalLines++;
            for (int i = y; i >= 0; i--)
            {
                if (picture[i][x] == 'B' || picture[i][x] == 'G')
                {
                    consideredBlue[i][x] = true;
                }
                else break;
            }
            for (int i = y + 1; i < picture.Length; i++)
            {
                if (picture[i][x] == 'B' || picture[i][x] == 'G')
                {
                    consideredBlue[i][x] = true;
                }
                else break;
            }
        }

        private void InitializeConsideredArray()
        {
            for (int i = 0; i < consideredRed.Length; i++)
            {
                consideredRed[i] = new bool[picture[i].Length];
                consideredBlue[i] = new bool[picture[i].Length];
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

