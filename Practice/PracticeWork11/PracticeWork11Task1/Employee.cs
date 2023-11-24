using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork11Task1
{
    public enum Vacancies
    {
        Director,
        Designer,
        Itspecialist,
        UIUX
    }

    struct Employee
    {
        public string name;
        public Vacancies vacancy;
        public int[] WorkDate;
        public int salary;

        public Employee(string name, Vacancies vacancy, int[] workDate, int salary)
        {
            this.name = name;
            this.vacancy = vacancy;
            this.WorkDate = workDate;
            this.salary = salary;
        }

    }
}
