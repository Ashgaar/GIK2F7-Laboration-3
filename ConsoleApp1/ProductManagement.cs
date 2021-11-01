using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProductManagement : Department
    {
        public ProductManagement(string name, string desc)
        {
            departmentName = name;
            departmentDesc = desc;
        }
    }
}
