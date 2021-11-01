using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Company
    {
        public string CompanyName;
        public int OrgNumber;
        public string URL;
        public string Address;

        public List<Department> department;
        public List<Employee> EmployeeList;
    }
}
