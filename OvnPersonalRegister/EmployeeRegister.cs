using System;
using System.Collections.Generic;
using System.Linq;

namespace OvnPersonalRegister
{
    internal class EmployeeRegistry
    {
        public EmployeeRegistry()
        {
            Employees = new List<Employee>();
        }

        private List<Employee> Employees { get; set; }

        internal void PrintEmployeeRegistry()
        {
            foreach (var employee in this.Employees)
            {
                System.Console.WriteLine($"Namn: {employee.Name}\tlön: {employee.Salary}\tlönenivå: {employee.SalaryLevel}");
            }
        }

        internal void PrintAvgSalaryAndEmployees()
        {
            int noEmp = Employees.Count;
            int sum = 0;
            foreach (var employee in this.Employees)
            {
                sum += employee.Salary;
            }
            Console.WriteLine($"Average salary: {(float)sum / noEmp}");
            PrintEmployeeRegistry();
        }

        internal void AddEmployeesAndSalary()
        {
            do
            {
                string name = null;
                string question = "Mata in namn";
                name = UI.Ask(question);

                if (name.Equals("0"))
                {
                    break;
                }

                question = "Mata in lön";
                int salary = UI.AskForInt(question);

                //string salaryLevel = getSalaryLevel(salary);

                Employee employee = new Employee(name, salary);
                Employees.Add(employee);
            } while (true);
        }

        internal void DeleteEmployee()
        {
            string name = UI.Ask("Vilken person vill du ta bort?");
            Employee empToDelete = Employees.SingleOrDefault(employee => employee.Name.Equals(name));
            if (empToDelete != null)
            {
                Employees.Remove(empToDelete);
            }

            PrintEmployeeRegistry();
        }
    }
}