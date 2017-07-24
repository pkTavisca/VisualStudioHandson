using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Codejam
{
    class TimeZone
    {
        static List<string> listOfTimes;
        public string GetTime(string timeString)
        {
            listOfTimes = new List<string>();
            int[] time = new int[6];

            if (!int.TryParse(timeString[0].ToString(), out time[0]))
            {
                time[0] = '?';
            }
            if (!int.TryParse(timeString[1].ToString(), out time[1]))
            {
                time[1] = '?';
            }
            if (!int.TryParse(timeString[3].ToString(), out time[2]))
            {
                time[2] = '?';
            }
            if (!int.TryParse(timeString[4].ToString(), out time[3]))
            {
                time[3] = '?';
            }

            if (timeString[9] == '+') time[4] = 1;
            else if (timeString[9] == '-') time[4] = 0;
            else time[4] = '?';

            if (!int.TryParse(timeString[10].ToString(), out time[5]))
            {
                time[5] = '?';
            }

            findTime(time);

            string min = listOfTimes[0];
            foreach (var t in listOfTimes)
            {
                if (t.CompareTo(min) < 0)
                {
                    min = t;
                }
            }

            return min;
        }

        public static void findTime(int[] time)
        {
            if (time[0] == '?')
            {
                for (int i = 0; i < 3; i++)
                {
                    int[] temp = (int[])time.Clone();
                    temp[0] = i;
                    findTime(temp);
                }
                return;
            }
            if (time[1] == '?')
            {
                int till = time[0] == 2 ? 4 : 10;
                for (int i = 0; i < till; i++)
                {
                    int[] temp = (int[])time.Clone();
                    temp[1] = i;
                    findTime(temp);
                }
                return;
            }
            if (time[2] == '?')
            {
                for (int i = 0; i < 6; i++)
                {
                    int[] temp = (int[])time.Clone();
                    temp[2] = i;
                    findTime(temp);
                }
                return;
            }
            if (time[3] == '?')
            {
                for (int i = 0; i < 10; i++)
                {
                    int[] temp = (int[])time.Clone();
                    temp[3] = i;
                    findTime(temp);
                }
                return;
            }
            if (time[4] == '?')
            {
                for (int i = 0; i < 2; i++)
                {
                    int[] temp = (int[])time.Clone();
                    temp[4] = i;
                    findTime(temp);
                }
                return;
            }
            if (time[5] == '?')
            {
                for (int i = 0; i < 10; i++)
                {
                    int[] temp = (int[])time.Clone();
                    temp[5] = i;
                    findTime(temp);
                }
                return;
            }

            if (time[4] == 1) time[5] *= -1;
            int hour = time[0] * 10 + time[1];
            hour += time[5];
            if (hour > 23) hour -= 24;
            else if (hour < 0) hour += 24;
            time[0] = hour / 10;
            time[1] = hour % 10;

            string finalTime = string.Format("{0}{1}:{2}{3}", time[0], time[1], time[2], time[3]);
            listOfTimes.Add(finalTime);

        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            TimeZone timeZone = new TimeZone();
            do
            {
                string validationOp = timeZone.GetTime(input);
                Console.WriteLine(validationOp);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}