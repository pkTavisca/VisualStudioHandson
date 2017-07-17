using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Codejam
{
    class Encryption
    {
        public string Encrypt(string test)
        {
            string result = "";
            char[] a = test.ToCharArray();
            Dictionary<char, char> dict = new Dictionary<char, char>();
            char b = 'a';
            for (int i = 0; i < a.Length; i++)
            {
                if (!dict.ContainsKey(a[i]))
                {
                    dict.Add(a[i], b++);
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                result += dict[a[i]];
            }
            return result;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            Encryption encryption = new Encryption();
            do
            {
                Thread th = new Thread(() =>
                {
                    try
                    {

                        string validationOp = encryption.Encrypt(input);
                        Console.WriteLine(validationOp);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception Occured" + ex.ToString());
                    }
                });
                th.Start();
                if (th.Join(1000) == false)
                {
                    Console.WriteLine("Timeout occured");
                    th.Abort();
                    return;
                }
                input = Console.ReadLine();

            } while (input != "-1");
        }

        #endregion
    }
}