using System;

namespace StudentGrade
{
    class Student
    {
        public string studentIDNo;

        public string firstName;
        public string middleName;
        public string lastName;
        public string dob;
        public string nationality;

        public string gender;
        public GradeProfile gradeProfile = new GradeProfile ();

        public Student (string studentIDNo, string firstName, string middleName, string lastName, string dob, string nationality, string gender)
        {
            this.studentIDNo = studentIDNo;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.dob = dob;
            this.nationality = nationality;
            this.gender = gender;
        }

        public void Display()
        {
            Console.WriteLine($"{firstName} {lastName}, \n");
            gradeProfile.Display();
        }
    }
}