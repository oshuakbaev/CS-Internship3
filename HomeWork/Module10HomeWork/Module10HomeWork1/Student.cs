using System;
using System.Xml.Linq;

namespace Module10HomeWork1
{
    public class Student : Person
    {
        public int Year { get; set; }

        public Student(string name, string lastName, int age, int year)
            : base(name, lastName, age)
        {
            Year = year;
        }

        public override string ToString()
        {
            return $"Student: {Name} {LastName}, Age: {Age}, Year: {Year}";
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Year: {Year}");
        }

     
    }
}
