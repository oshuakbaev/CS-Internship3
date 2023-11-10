using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Module10HomeWork1
{
    public class Teacher : Person
    {
        public List<Student> Students { get; set; }

        public Teacher(string name, string lastName, int age)
            : base(name, lastName, age)
        {
            Students = new List<Student>();
        }

       
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                Console.WriteLine($" - {student.Name} {student.LastName}");
            }
        }

        public override string ToString()
        {
            return $"Teacher: {Name} {LastName}, Age: {Age}, Number of Students: {Students.Count}";
        }


        public void AddStudent(Student student)
        {
            Students.Add(student);
        }


    }
}
