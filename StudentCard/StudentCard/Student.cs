using System;

namespace StudentCard
{
    class Student
    {
        public string studentIdNo;
        public string firstName;
        public string middleName;
        public string lastName;
        public string dob;
        public string nationality;
        public string gender;

        //public void GetStudentGradeProfile()
        //{};
        public Student(string studentIdNo, string firstName, string middleName, string lastName, string dob, string nationality, string gender)
        {
            this.studentIdNo = studentIdNo;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.dob = dob;
            this.nationality = nationality;
            this.gender = gender;
        }
    }
}