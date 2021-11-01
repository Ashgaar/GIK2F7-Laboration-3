using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Company groceryStore = new Company();
            groceryStore.CompanyName = "ICA";
            groceryStore.OrgNumber = 18045;
            groceryStore.URL = "https://www.grocerystore.urlend";
            groceryStore.Address = "Addressgatan 1";

            var eco = new Economy("Economy", "....");
            var hr = new HR("Human Relations", "....");
            var it = new IT("IT", "....");
            var legal = new Legal("Legal", "....");
            var productMgmt = new ProductManagement("Product Management", "....");

            eco.EmployeeList = new List<Employee>
            {
                new Employee("Ingvar Hansson", 1,eco.departmentName, "..."),
                new Employee("Oscar Hansson", 1,eco.departmentName, "..."),
            };
            hr.EmployeeList = new List<Employee>
            {
                new Employee("Ingvar Johnsson", 1,hr.departmentName, "..."),
                new Employee("Oscar Johnsson", 1,hr.departmentName, "..."),
            };
            it.EmployeeList = new List<Employee>
            {
                new Employee("Ingvar Svensson", 1,it.departmentName, "..."),
                new Employee("Oscar Svensson", 1,it.departmentName, "..."),
            };
            legal.EmployeeList = new List<Employee>
            {
                new Employee("Ingvar Hirvelä", 1,legal.departmentName, "..."),
                new Employee("Oscar Hirvelä", 1,legal.departmentName, "..."),
            };
            productMgmt.EmployeeList = new List<Employee>
            {
                new Employee("Ingvar Kamprad", 1,productMgmt.departmentName, "..."),
                new Employee("Oscar Kamprad", 1 , productMgmt.departmentName, "..."),
            };

            groceryStore.department = new List<Department>
            {
                eco,
                hr,
                it,
                legal,
                productMgmt
            };

            Console.WriteLine($"Company Name {groceryStore.CompanyName}\nCompany Organizationnumber {groceryStore.OrgNumber}\nCompany URL {groceryStore.URL}\n");

            foreach (var department in groceryStore.department)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine(department.ToString());
                Console.WriteLine("------------------------------------------------------------");

                if (department.EmployeeList.Count > 0)
                {
                    foreach (var employee in department.EmployeeList)
                    {
                        Console.WriteLine(employee.ToString());
                    }
                }
                else
                {
                    Console.WriteLine($"{department.departmentName} has no employees");
                }
            }
        }
    }
}