using System;

namespace Module10HomeWork1
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }

       

        public override string ToString()
        {
            return $"Person: {Name} {LastName}, Age: {Age}";
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, Last Name: {LastName}, Age: {Age}");
        }
    }
}
