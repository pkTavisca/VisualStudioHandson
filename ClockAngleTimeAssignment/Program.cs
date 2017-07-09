using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngleTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the theta value in degrees: ");
            double theta = double.Parse(Console.ReadLine());
            Console.Write("Enter the Timezone Id: ");
            string tId = Console.ReadLine();
            theta %= 180;
            double hourDps = 360.0 / (12 * 60 * 60);
            double minuteDps = 360.0 / (60 * 60);
            double diffSpeed = minuteDps - hourDps;
            double thetaBig = 360 - theta;
            double timeFor1Turn = 360.0 / (diffSpeed * 60 * 60);
            for (double t = 0; t <= 12; t += timeFor1Turn)
            {
                double t1 = t + theta / (diffSpeed * 60 * 60);
                double t2 = t + thetaBig / (diffSpeed * 60 * 60);
                Console.WriteLine(ToTimezoneTime(convertToTime(t1), tId));
                if (theta == 0) continue;
                Console.WriteLine(ToTimezoneTime(convertToTime(t2), tId));
            }

            Console.ReadKey(true);
        }

        public static string ToTimezoneTime(int[] time, string tId)
        {
            DateTime now = DateTime.Now.Date.Add(new TimeSpan(0, time[0], time[1], time[2], time[3]));
            DateTimeOffset converted = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(now, tId);
            return converted.TimeOfDay.ToString();
        }

        public static int[] convertToTime(double time)
        {
            int[] factoredTime = new int[4];
            factoredTime[0] = (int)time;
            double mins = (time - (int)time) * 60;
            factoredTime[1] = (int)mins;
            double secs = (mins - (int)mins) * 60;
            factoredTime[2] = (int)secs;
            double millis = (secs - (int)secs) * 100;
            factoredTime[3] = (int)millis;
            return factoredTime;
        }

        public static void print(int[] time)
        {
            for (int i = 0; i < time.Length; i++)
            {
                Console.Write(time[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
