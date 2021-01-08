using System;
using System.Collections.Generic;

namespace StudentGrade
{
    class ModuleGrade
    {
        public List<Grade> grades = new List<Grade> ();
        public string ModuleName{get; set;}

        public ModuleGrade(string moduleName)
        {
            ModuleName = moduleName;
        }

        
    }
}