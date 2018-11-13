using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverload
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string Rate { get; set; }

        public static bool Equals(Employee employee1, Employee employee2)
        {
            Console.WriteLine(employee1.EmployeeId == employee2.EmployeeId);
            return (employee1.EmployeeId==employee2.EmployeeId);
        }
    }      
       
}
