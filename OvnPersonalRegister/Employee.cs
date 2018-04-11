using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvnPersonalRegister
{
    class Employee
    {
        private int salary;

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public int Salary
        {
            get => salary;
            set
            {
                salary = value;
                SalaryLevel = getSalaryLevel(salary);
            } 
        }

        public string SalaryLevel { get; set; }

        private string getSalaryLevel(int salary)
        {
            string salaryLevel = "Undefined";
            if (salary >= 40000)
            {
                salaryLevel = "High";
            }
            else if (salary >= 30000)
            {
                salaryLevel = "Ok";
            }
            else if (salary < 30000)
            {
                salaryLevel = "Bad";
            }
            return salaryLevel;
        }

    }
}
