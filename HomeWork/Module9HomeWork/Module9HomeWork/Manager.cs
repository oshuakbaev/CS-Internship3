using System;
namespace Module9HomeWork
{
	public class Manager : Employee
	{
		public int Bonus { get; set; }

		public Manager(int bonus, string name, int age, int salary) : base(name,age,salary)
		{
            this.Salary = salary;
        }

        public override void CalculateAnnualSalary()
        {
            Console.WriteLine("Annual salary is : " + (Salary * 12+Bonus));
        }


    }
}

