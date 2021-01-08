using System;
using System.Collections.Generic;

namespace StudentCard
{
    class GradeProfile
    {
       public List<Grade> studentGrade = new List<Grade> ();

       public string assignment;
       public string averageYearlyGrade;

       public void GetStudentGrades()
       {}

       public void GetStudentIDNo()
        {}

       public void GetModule()
       {}

       public string CalculateGradeWeight();
        

       public double CalculateAverageYearlyGrade();

    }
}