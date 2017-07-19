using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class ReferenceTypeAndValueType
    {
        public static void Display()
        {
            List<int> list = new List<int>();
            list.Add(5);
            int a = 5;
            PassValue(a);
            PassReference(list);
            Console.WriteLine(a + " and " + list[0]);
        }

        private static void PassReference(List<int> list)
        {
            list.RemoveAt(0);
            list.Add(15);
        }

        private static void PassValue(int a)
        {
            a = 15;
        }
    }
}
