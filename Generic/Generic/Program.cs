using Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string> { "Joe", "John" };
            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int> { 1, 2, 3, 4 };
            employee.Print(employee.Things);
            employee1.Print(employee1.Things);
            
            Console.ReadLine();
            

                        




        }
    }
}
