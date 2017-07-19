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
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter breadth : ");
            int breadth = int.Parse(Console.ReadLine());
            CalculateAreaAndPerimeter(length, breadth);
        }
        public static void CalculateAreaAndPerimeter(int length, int breadth)
        {
            Console.WriteLine("Perimeter : " + ((length + breadth) * 2));
            Console.WriteLine("Area: " + (length * breadth));
        }
    }
}
