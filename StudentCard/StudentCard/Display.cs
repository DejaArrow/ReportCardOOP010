using System;

namespace StudentCard
{
    class Display
    {   
            public void DisplayStudent()
            {
             Student student1 = new Student("1", "Bobson", "Chaos", "Dugnett", "10 October 2009", "British", "Male");
             Student student2 = new Student("2", "Sleve", "Order", "McDichael", "2 July 2009", "British", "Male");

             Console.WriteLine($"{student1}");
             Console.WriteLine($"{student2}");
            }
    }
}