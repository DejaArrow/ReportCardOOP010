using System;

namespace StudentCard
{
    class GradeProfile
    {
       public list studentGrade;
       public string assignment;
       public string averageYearlyGrade;

       public void GetStudentGrades();

       public void GetStudentIDNo(){get; set;};

       public void GetModule(){get; set;};

       public string CalculateGradeWeight()
        {};

       public double CalculateAverageYearlyGrade();

    }
}