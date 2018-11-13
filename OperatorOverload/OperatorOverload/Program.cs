using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.EmployeeId = 105;
            employee2.EmployeeId = 105;
            Employee.Equals(employee1, employee2);
            Console.ReadLine();
        }
    }
}
