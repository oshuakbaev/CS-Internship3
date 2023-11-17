using System;
using System.Globalization;
using System.Reflection;
using System.Xml.Linq;
using HomeWork11Task1;

namespace HomeWork11
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();

            // для проверки 
            //employees.Add(new Employee("Evgenii", 18, "director", 50000000000, 1, "Gertzen", new DateTime(2000, 1, 1), "male"));
            //employees.Add(new Employee("Evgenii1", 18, "zam-director", 500000, 2, "Gertzen1", new DateTime(2006, 5, 6), "male"));
            //employees.Add(new Employee("Evgenii2", 18, "admin", 5000000, 3, "Gertzen2", new DateTime(2007, 1, 2), "male"));
            //employees.Add(new Employee("Evgenii3", 18, "it-specialist", 5000000, 4, "Gertzen3", new DateTime(2022, 7, 1), "male"));
            //employees.Add(new Employee("Anna", 18, "manager", 5000000, 5, "Gertzen4", new DateTime(2022, 7, 1), "female"));

            int NumberOfEmployee = 0;
            try
            {
                Console.WriteLine("сколько сотрудников?");
                NumberOfEmployee = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Введите число пожалуйста");
            }

            for (int i = 0; i < NumberOfEmployee; i++)
            {
                Console.WriteLine("Введите пожалуйста данные для сотрудника: ");
                Console.WriteLine("Введите имя"); 
                string name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                string surname = Console.ReadLine();
                Console.WriteLine("Введите Возраст");
                int age = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите должность");
                string position = Console.ReadLine();
                Console.WriteLine("Введите зарплату");
                decimal salary = Decimal.Parse(Console.ReadLine());
               
                int id = i;
                Console.WriteLine("Введите пол");
                string gender = Console.ReadLine();
               
                Console.WriteLine("Введите дату приема на работу в формате ГГГГ.ММ.ДД:");
                string dateString = Console.ReadLine();
                DateTime hireDate;

                // Попытка преобразовать введенную пользователем строку в DateTime
                if (DateTime.TryParseExact(dateString, "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out hireDate))
                {

                    employees.Add(new Employee(name, age, position, salary, id, surname, hireDate, gender)); 
                 
                }
                else
                {
                    
                    Console.WriteLine("Некорректный формат даты.");
                   
                }

                

            }


            Console.WriteLine(" Все сотрудники");
            GetEmployeeFullInformation(employees);
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("определенной должностью");
            InformationByPosition(employees, "manager");
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("средняя зарплата больше клерков");
            SalaryCalculation(employees);
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("определенной даты");
            DateInformationHire(employees,new DateTime(2000,1,1));
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("какого пола нужно");
            GenderInfo(employees, "female");


        }


        // Вывести информацию обо всех сотрудниках.
        public static void GetEmployeeFullInformation(List<Employee> employees)
        {
            foreach(var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }


        // Вывести информацию о сотрудниках определенной должности.
        public static void InformationByPosition(List<Employee> employees, string position)
        {
            foreach (var employee in employees)
            {
                if(employee.Position == position)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
        }

        // Найти и вывести менеджеров с зарплатой выше средней зарплаты клерков.
        public static void SalaryCalculation(List<Employee> employees)
        {
            long sum = 0;
            foreach( var employee in employees)
            {
                sum = sum + (long)employee.Salary;
            }

            long mediumSalary = sum / employees.Count;

            foreach( var employee in employees)
            {
                if(mediumSalary > employee.Salary)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
            
        }

        public static void DateInformationHire(List<Employee> employees, DateTime date)
        {
            foreach( var employee in employees)
            {
                if(date < employee.HireTime) {
                
                    Console.WriteLine(employee.ToString());
                }
            }
        }

        public static void GenderInfo(List<Employee> employees, string gender)
        {
            foreach( var employee in employees)
            {
                if(gender == employee.Gender) {
                
                Console.WriteLine(employee.ToString());
                
                }
            }
        }
    }
}