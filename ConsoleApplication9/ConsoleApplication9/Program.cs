using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            Employee employee = new Employee();
            List<Employee> Employees = new List<Employee>()
            {
                new Employee() {FirstName = "Joe", LastName = "Johnson", ID = 0 },
                new Employee() {FirstName = "Joe", LastName = "Smith", ID = 1 },
                new Employee() {FirstName = "John", LastName = "Lockhart", ID = 2 },
                new Employee() {FirstName = "Jerry", LastName = "Swinnie", ID = 3 },
                new Employee() {FirstName = "Jesse", LastName = "Mcgregor", ID = 4 },
                new Employee() {FirstName = "Jacob", LastName = "Jones", ID = 5 },
                new Employee() {FirstName = "Jerry", LastName = "Wright", ID = 6 },
                new Employee() {FirstName = "Lonnie", LastName = "Chisenhall", ID = 7  },
                new Employee() {FirstName = "Frank", LastName = "Thomas", ID = 8 },
                new Employee() {FirstName = "Evander", LastName = "Holyfield", ID = 9 }

            };

           
            List<Employee> Joes = new List<Employee>();

            foreach (Employee joe in Employees)
            {
                
                if (joe.FirstName == "Joe")
                {
                    Joes.Add(joe);
                }

            }

            List<Employee> _id = Employees.Where(x => x.ID > 5).ToList();

            List<Employee> First = Employees.Where(y => y.FirstName == "Joe").ToList();

            foreach (Employee first in First)
            {
                Console.WriteLine(first.FirstName);
                    
            }
            
        } 
    }
}
