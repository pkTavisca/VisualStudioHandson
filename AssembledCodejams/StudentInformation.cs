using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembledCodejams
{
    class StudentInformation
    {
        public static void DisplayStudentInformation()
        {
            Console.Write("Enter student's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student's roll number: ");
            string rollNo = Console.ReadLine();
            Console.Write("Enter student's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter student's class: ");
            string classOfStudent = Console.ReadLine();
            Console.Write("Enter student's university name: ");
            string universityName = Console.ReadLine();

            Console.WriteLine(name + "\n" + rollNo + "\n" + age + "\n" + classOfStudent + "\n" + universityName);
        }
    }
}
