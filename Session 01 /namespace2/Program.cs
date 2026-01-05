using System;
using SchoolApp.Teachers; 
using SchoolApp.Students;  
using SchoolApp.Subjects;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to SCHOOL!!");

            // creating teacher1 object 
            Teachers.Teacher teacher1 = new Teachers.Teacher("Jahid");

            //creating student1 object
            Students.Student student1 = new Students.Student("Evan", 25);

            // creating subject1 object
            Subjects.Subject subject1 = new Subjects.Subject("Math");

            student1.Study();
            teacher1.Teach();
            subject1.Display();
        }
    }
}