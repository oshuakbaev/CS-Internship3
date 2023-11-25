using System;
namespace Module9HomeWork
{
	public class Developer : Employee
	{
		public int LinesOfCodePerDay { get; set; }
		public Developer(int linesOfCodePerDay,string name, int age, int salary):base(name,age,salary)
		{
			this.LinesOfCodePerDay = linesOfCodePerDay;
		}

        public override void CalculateAnnualSalary()
        {
			Console.WriteLine("Annual of Developer is: "+(Salary*12+LinesOfCodePerDay*1000));
        }


    }
}

