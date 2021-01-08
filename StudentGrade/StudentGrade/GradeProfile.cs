using System;
using System.Collections.Generic;

namespace StudentGrade
{
    class GradeProfile
    {
        public List<ModuleGrade> studentgrades = new List<ModuleGrade> ();


        public void Display()

            {

                foreach(ModuleGrade moduleGrade in studentgrades)
                {   
                    Console.WriteLine($"Module: {moduleGrade.ModuleName}");

                    double moduleTotal=0;

                    foreach(Grade grade in moduleGrade.grades)
                    {
                        moduleTotal+=(grade.GradeValue * grade.GradeWeight);
                        grade.Display();
                    }

                    Console.WriteLine($" Module average: {moduleTotal}\n");
                }

            }
        
    }
}