using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class RGB
    {
        bool[][] considered;
        string[] picture;
        int totalLines;
        int GetLeast(string[] picture)
        {
            totalLines = 0;
            considered = new bool[picture.Length][];
            this.picture = picture;

            InitializeConsideredArray(ref considered);

            for (int i = 0; i < picture.Length; i++)
            {
                for (int j = 0; j < picture[i].Length; j++)
                {
                    if (picture[i][j] != '.' && !considered[i][j])
                        Process(i, j);
                }
            }
            return totalLines;
        }

        private void Process(int x, int y)
        {
            if (picture[x][y] == 'R')
            {
                ProcessX(x, y);
            }
            else if (picture[x][y] == 'B')
            {
                ProcessY(x, y);
            }
            else if(picture[x][y] == 'G')
            {
                ProcessG(x, y);
            }
        }

        private void ProcessX(int x, int y)
        {
            totalLines++;
            for (int i = x; i >= 0; i--)
            {
                if (picture[i][y] == 'R')
                {
                    considered[i][y] = true;
                }
                else if (picture[i][y] == 'G')
                {
                    ProcessY(i, y);
                    considered[i][y] = true;
                }
                else break;

            }
            for (int i = x; i < picture.Length; i++)
            {
                if (picture[i][y] == 'R')
                {
                    considered[i][y] = true;
                }
                else if (picture[i][y] == 'G')
                {
                    ProcessY(i, y);
                    considered[i][y] = true;
                }
                else break;
            }
        }

        private void ProcessY(int x, int y)
        {
            totalLines++;
            for (int i = y; i >= 0; i--)
            {
                if (picture[x][i] == 'B')
                {
                    considered[x][i] = true;
                }
                else if (picture[x][i] == 'G')
                {
                    ProcessX(x, i);
                    considered[x][i] = true;
                }
                else break;
            }
            for (int i = y; i < picture.Length; i++)
            {
                if (picture[x][i] == 'B')
                {
                    considered[x][i] = true;
                }
                else if (picture[x][i] == 'G')
                {
                    ProcessX(x, i);
                    considered[x][i] = true;
                }
                else break;
            }
        }

        private void ProcessG(int x, int y)
        {
            totalLines += 2;
            for (int i = x; i < picture.Length; i++)
            {
                if (picture[i][y] == 'R')
                {
                    considered[i][y] = true;
                }
                else if (picture[i][y] == 'G')
                {
                    ProcessY(i, y);
                    considered[i][y] = true;
                }
                else break;
            }
            for (int i = y; i < picture.Length; i++)
            {
                if (picture[x][i] == 'B')
                {
                    considered[x][i] = true;
                }
                else if (picture[x][i] == 'G')
                {
                    ProcessX(x, i);
                    considered[x][i] = true;
                }
                else break;
            }
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

