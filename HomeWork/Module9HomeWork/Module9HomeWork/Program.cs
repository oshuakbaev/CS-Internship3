using System;


namespace Module9HomeWork
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Evgenii",33,5000000);
            Manager manager = new Manager(300, "John", 22, 30000);
            Developer developer = new Developer(333, "Brat", 21, 30002);


            Console.WriteLine($"Employee name: {employee.Name}" +
                $"\nEmployee age: {employee.Age}" +
                $"\nEmployee salary: {employee.Salary}" +
                $"\nEmployee annual salary: {employee.CalculateAnnualSalary}\n");

            Console.WriteLine($"Manager name: {manager.Name}" +
                $"\nManager age: {manager.Age}" +
                $"\nManager salary: {manager.Salary}" +
                $"\nManager annual salary: {manager.CalculateAnnualSalary}\n");

            Console.WriteLine($"Developer name: {developer.Name}" +
                $"\nDeveloper age: {developer.Age}" +
                $"\nDeveloper salary: {developer.Salary}" +
                $"\nManager annual salary: {developer.CalculateAnnualSalary}");
        }
    }
}