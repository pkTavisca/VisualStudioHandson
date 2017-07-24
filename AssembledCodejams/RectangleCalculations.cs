using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class RectangleCalculations
    {
        public static void Calculate()
        {
            Console.Write("Enter length : ");
            int length;
            int.TryParse(Console.ReadLine(), out length);

            Console.Write("Enter breadth : ");
            int breadth;
            int.TryParse(Console.ReadLine(), out breadth);

            Console.WriteLine("Perimeter of the Rectangle: {0}", Perimeter(length, breadth));
            Console.WriteLine("Area of the Rectangle: {0}", Area(length, breadth));
        }

        public static int Area(int length, int breadth)
        {
            return length * breadth;
        }

        public static int Perimeter(int length, int breadth)
        {
            return 2 * (length + breadth);
        }
    }
}
