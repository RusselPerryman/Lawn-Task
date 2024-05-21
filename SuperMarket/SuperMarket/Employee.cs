using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
        public class Employee
        {
            public string Name { get; set; }

            public int EmployeeID { get; set; }

            public Employee(string name, int employeeID)
            {
                Name = name;
                EmployeeID = employeeID;
            }
        }
}
