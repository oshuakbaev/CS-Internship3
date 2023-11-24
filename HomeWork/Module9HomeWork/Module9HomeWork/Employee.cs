using System;
namespace Module9HomeWork
{
	public class Employee
	{
		public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary; 
        }


        public void GetInfo(string name) {

            if(this.Name.Equals(name,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Name: "+Name);
                Console.WriteLine("Age: "+Age);
                Console.WriteLine("Salary: "+Salary);

            }
            else
            {
                Console.WriteLine("this employee not found");
            }
            
        }

        public void CalculateAnnualSalary()
        {
            Console.WriteLine("Annual salary is : " + Salary * 12);
        }


    }
}

