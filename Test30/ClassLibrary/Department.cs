using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Department
    {

        public Department()
        {
            this.Employees = new Employee [0];
        }
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public double SalaryLimit { get; set; }
        public Employee[] Employees;

        public void AddEmployee(Employee employee)
        {
            if (this.EmployeeLimit > this.Employees.Length)
            {
            Array.Resize(ref this.Employees, this.Employees.Length + 1);
            this.Employees[this.Employees.Length - 1] = employee;
            }
        }

    }
}
