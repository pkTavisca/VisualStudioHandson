using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Codejam
{
    class Dating
    {
        String Dates(String circle, int k)
        {
            string dates = string.Empty;

            ArrayList people = new ArrayList();
            ArrayList men = new ArrayList();
            ArrayList women = new ArrayList();

            for (int i = 0; i < circle.Length; i++)
            {
                people.Add(circle[i]);
                if (IsFemale(circle[i]))
                    women.Add(circle[i]);
                if (IsMale(circle[i]))
                    men.Add(circle[i]);
            }
            men.Sort();
            women.Sort();
            int position = k % people.Count;

            while (men.Count > 0 && women.Count > 0)
            {
                char individual = (char)people[position - 1];
                if (IsMale(individual))
                {
                    char woman = (char)women[0];
                    dates += individual.ToString() + woman + " ";
                    int indexI = people.IndexOf(individual);
                    int indexF = people.IndexOf(woman);
                    if (indexI < position - 1)
                    {
                        position--;
                        position %= people.Count;
                    }
                    if (indexF < position - 1)
                    {
                        position--;
                        position %= people.Count;
                    }
                    men.Remove(individual);
                    women.Remove(woman);
                    people.Remove(individual);
                    people.Remove(woman);
                }
                else if (IsFemale(individual))
                {
                    char man = (char)men[0];
                    dates += individual.ToString() + man + " ";
                    int indexI = people.IndexOf(individual);
                    int indexM = people.IndexOf(man);
                    if (indexI < position - 1)
                    {
                        position--;
                        position %= people.Count;
                    }
                    if (indexM < position - 1)
                    {
                        position--;
                        position %= people.Count;
                    }
                    women.Remove(individual);
                    men.Remove(man);
                    people.Remove(individual);
                    people.Remove(man);
                }
                position = ((position - 1 + k) % people.Count) + 1;
            }

            return dates.TrimEnd();
        }

        bool IsMale(char c)
        {
            if (c >= 'A' && c <= 'Z')
                return true;
            return false;
        }
        bool IsFemale(char c)
        {
            if (c >= 'a' && c <= 'z')
                return true;
            return false;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            Dating dating = new Dating();

            do
            {
                string[] values = input.Split(',');
                Console.WriteLine(dating.Dates(values[0], Int32.Parse(values[1])));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}