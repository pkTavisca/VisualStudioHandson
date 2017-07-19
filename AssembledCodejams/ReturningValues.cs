using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class ReturningValues
    {
        public static void ReturnSomething()
        {
            Console.WriteLine(Add.Addition(5, 8));
        }
    }

    class Add
    {
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
