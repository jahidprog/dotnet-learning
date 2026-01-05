using System;

namespace SchoolApp.Students  
{
    public class Student
    {
        public string Name {get; set;}
        public int Age {get; set;}

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Study()
        {
            Console.WriteLine($" Student {Name} (age {Age}): I am studying!");
        }
    }
}