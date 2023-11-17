using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork11Task1
{
    public struct Employee : IEmployee
    {
        public string Name { get; set;  }
        public string Surname { get; set;  }

        public string Position { get; set; }

        public decimal Salary { get; set; }

        public int Id { get; set; }

        public int Age { get; set; }

        public DateTime HireTime { get; }

        public string Gender { get; set; }



        public Employee(string name, int age, string position,  decimal salary, int id, string surname, DateTime hiretime,string gender)
        {
            Name = name;
            Age = age;
            Position = position;
            Salary = salary;
            Id = id;
            Surname = surname;
            HireTime = hiretime;
            Gender = gender;
            
        }

        public override string ToString()
        {
            return $"Имя:{Name},Фамилия:{Surname},Возраст:{Age},Должность: {Position},Зарплата:{Salary},ID:{Id},Date:{HireTime}";
        }


        public string GetEmployeeDetailsPosition()
        {
            return Position;
        }

        

    }
}
