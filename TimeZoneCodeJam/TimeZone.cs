using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Codejam
{
    class TimeZone
    {
        public string GetTime(string time)
        {
            //int hourTens = -1;
            //int hourUnits = -1;
            //int minsTens = -1;
            //int minsUnits = -1;
            //char sign = time[9];
            //int gmtDeviation = -1;

            //int.TryParse(time[0].ToString(), out hourTens);
            //int.TryParse(time[1].ToString(), out hourUnits);
            //int.TryParse(time[3].ToString(), out minsTens);
            //int.TryParse(time[4].ToString(), out minsUnits);
            //int.TryParse(time[10].ToString(), out gmtDeviation);

            int i = 0;
            do
            {
                Console.WriteLine(i++);
            } while (i<5);

            return String.Empty;
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