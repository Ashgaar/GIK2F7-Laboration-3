using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Department : Company
    {
        public string departmentName;
        public string departmentDesc;

        public override string ToString()
        {
            string info = $"{departmentName} department. Desc: {departmentDesc}";
            return info;
        }
    }
}
