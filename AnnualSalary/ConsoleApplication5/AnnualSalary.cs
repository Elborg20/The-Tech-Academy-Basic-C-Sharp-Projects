using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Tool");
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly rate:");
            string Hourly1 = Console.ReadLine();
            Console.WriteLine("Please enter your hours worked per week:");
            string WeeklyHours1 = Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate:");
            string Hourly2 = Console.ReadLine();
            Console.WriteLine("Please enter your hours worked per week:");
            string WeeklyHours2 = Console.ReadLine();
            Double Annual1 = (365 / 7 * Convert.ToDouble(Hourly1) * Convert.ToDouble(WeeklyHours1));
            Console.WriteLine("Annual Salary of Person 1");
            Console.WriteLine(Annual1);
            Console.ReadLine();
            double Annual2 = (365 / 7 * Convert.ToDouble(Hourly2) * Convert.ToDouble(WeeklyHours2));
            Console.WriteLine("Annual Salary of Person 2");
            Console.WriteLine(Annual2);
            Console.ReadLine();
            bool TorF = Annual1 > Annual2;
            Console.WriteLine("Does Person 1 make more money than person 2?");
            Console.WriteLine(TorF);
            Console.ReadLine();

        }
    }
}
