using System;

namespace SchoolApp.Subjects
{
    public class Subject
    {
        public string Name {get; set;}

        public Subject(string name) // constructor
        {
            Name = name;
        }

        public void Display() // display function 
        {
            Console.WriteLine($"Subject: {Name}");
        }
    }
}