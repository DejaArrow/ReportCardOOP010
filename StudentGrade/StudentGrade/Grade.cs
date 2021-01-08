using System;

namespace StudentGrade
{
    class Grade
    {
        public double GradeValue;
        public double GradeWeight;

        public Grade (double grade, double gradeWeight)
        {
            GradeValue = grade;
            GradeWeight = gradeWeight;
        }

        public void Display()
        {
            Console.WriteLine($" Grade: {GradeValue}. Weighting: {GradeWeight}.");
        }
    }
}