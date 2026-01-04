using System;

namespace Welcome
{
    class Student
    {
        public string Name;
        public int Age;
        public int Roll;

        public Student(string name, int age, int roll){
            Name = name;
            Age = age;
            Roll = roll;
        }

        public void StudentDetails()
        {   
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Roll);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Jahid", 26, 11);
            s1.StudentDetails();
        }
    }

    
}