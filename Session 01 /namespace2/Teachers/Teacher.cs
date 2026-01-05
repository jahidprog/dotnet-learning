using System;

namespace SchoolApp.Teachers
{
    public class Teacher
    {
        public string Name {get; set;}

        public Teacher(string name) // constructor
        {
            Name = name;
        }

        public void Teach()
        {
            Console.WriteLine($"Teacher {Name}: I am teaching the class!");
        }
    }
}