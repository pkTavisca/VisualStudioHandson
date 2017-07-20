namespace AssembledCodejams
{
    class Student
    {
        string name;
        int rollNo;
        int age;
        string classOfStudent;
        string university;

        public Student(string name, int rollNo, int age, string classOfStudent, string university)
        {
            this.name = name;
            this.rollNo = rollNo;
            this.age = age;
            this.classOfStudent = classOfStudent;
            this.university = university;
        }

        override
        public string ToString()
        {
            return string.Format("Name: {0}\nRoll No.: {1}\nAge: {2}\nClass: {3}\nUniversity: {4}", name, rollNo, age, classOfStudent, university);
        }
    }
}
