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
            //Input 
            Console.Write("Enter student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter student's roll number: ");
            int rollNo;
            int.TryParse(Console.ReadLine(), out rollNo);

            Console.Write("Enter student's age: ");
            int age;
            int.TryParse(Console.ReadLine(), out age);

            Console.Write("Enter student's class: ");
            string classOfStudent = Console.ReadLine();

            Console.Write("Enter student's university name: ");
            string universityName = Console.ReadLine();

            Student student = new Student(name, rollNo, age, classOfStudent, universityName);

            Console.WriteLine(student.ToString());
        }
    }
}
