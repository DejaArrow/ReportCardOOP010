using System;
using System.Collections.Generic;

namespace StudentGrade
{
    class App
    {

    

       public App()
       {    
           List<Student> students = new List<Student>();

           students.Add (new Student ("1", "Bobson", "Chaos", "Dugnett", "10 October 2009", "British", "Male") );
           students.Add (new Student("2", "Sleve", "Order", "McDichael", "2 July 2009", "British", "Male") );
           
          

           students[0].gradeProfile.studentgrades.Add(new ModuleGrade("Programming"));
           students[0].gradeProfile.studentgrades[0].grades.Add(new Grade(65, 0.5));
           students[0].gradeProfile.studentgrades[0].grades.Add(new Grade(57, 0.5));

            students[0].gradeProfile.studentgrades.Add(new ModuleGrade("Database"));
           students[0].gradeProfile.studentgrades[1].grades.Add(new Grade(71, 0.7));
           students[0].gradeProfile.studentgrades[1].grades.Add(new Grade(62, 0.3));

           students[1].gradeProfile.studentgrades.Add(new ModuleGrade("Programming"));
           students[1].gradeProfile.studentgrades[0].grades.Add(new Grade(82, 0.5));
           students[1].gradeProfile.studentgrades[0].grades.Add(new Grade(75, 0.5));

            students[1].gradeProfile.studentgrades.Add(new ModuleGrade("Database"));
           students[1].gradeProfile.studentgrades[1].grades.Add(new Grade(89, 0.7));
           students[1].gradeProfile.studentgrades[1].grades.Add(new Grade(79, 0.3));

            foreach (Student student in students)
            {
                student.Display();
            }

         }
    }
}