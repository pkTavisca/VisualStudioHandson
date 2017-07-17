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
                if (IsMale(circle[i]))
                    men.Add(circle[i]);
                else
                    women.Add(circle[i]);
            }
            men.Sort();
            women.Sort();

            int position = (k - 1) % people.Count;

            while (men.Count > 0 && women.Count > 0)
            {
                char individual = (char)people[position];
                if (IsMale(individual))
                {
                    char woman = (char)women[0];
                    dates += individual.ToString() + woman + " ";
                    men.Remove(individual);
                    Remove(ref position, people.IndexOf(individual), people);
                    women.Remove(woman);
                    Remove(ref position, people.IndexOf(woman), people);
                }
                else
                {
                    char man = (char)men[0];
                    dates += individual.ToString() + man + " ";
                    women.Remove(individual);
                    Remove(ref position, people.IndexOf(individual), people);
                    men.Remove(man);
                    Remove(ref position, people.IndexOf(man), people);
                }
                if (k > 1 && people.Count > 0)
                    position = (position + k - 1) % people.Count;
            }

            return dates.TrimEnd();
        }

        void Remove(ref int position, int toRemoveIndex, ArrayList circle)
        {
            if (toRemoveIndex < position)
            {
                position--;
            }
            else if (toRemoveIndex == position && position == circle.Count - 1)
            {
                position = 0;
            }
            circle.RemoveAt(toRemoveIndex);
        }

        bool IsMale(char c)
        {
            if (c >= 'A' && c <= 'Z')
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