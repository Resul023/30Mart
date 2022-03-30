using System;
using ClassLibrary;
namespace Test30
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.NameTool = "Hikmet";
            employee1.SurNameTool = "Abbsaov";
            employee1.SalaryTool = 750;

            Employee employee2 = new Employee();
            employee2.NameTool = "Jr.Hikmet";
            employee2.SurNameTool = "Abbsaov";
            employee2.SalaryTool = 800;

            Employee employee3 = new Employee();
            employee3.NameTool = "Hikmet3";
            employee3.SurNameTool = "Abbsaov3";
            employee3.SalaryTool = 200;

            Department hikocompany = new Department();
            hikocompany.EmployeeLimit = 1;
            hikocompany.AddEmployee(employee1);
            hikocompany.AddEmployee(employee2);
            hikocompany.AddEmployee(employee3);
            foreach (var item in hikocompany.Employees)
            {
                Console.WriteLine($"Employee name-{item.NameTool} Employee surname-{item.SurNameTool} Employee salary-{item.SalaryTool}");
            }



        }
    }
}
