using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public string name; // Employee Name
        public int eId; // Employee Id
        public string department; // Employee Department
        public string task; // Employee task within department

        public Employee(string Name, int ID, string Department, string Task )
        {
            name = Name;
            eId = ID;
            department = Department;
            task = Task;
        }

        public override string ToString()
        {
            string info = $"Employees name: {name} \nEmployee ID: {eId} \nEmployee Department: {department} \nEmployee Task: {task}\n";
            return info;
        }
    }
}
