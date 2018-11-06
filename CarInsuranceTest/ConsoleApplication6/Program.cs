using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI?  Please answer \"true\"or \"false\".");
            string DUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string speeding = Console.ReadLine();
            bool Qualified = (Convert.ToInt16(Age) > 15 && "false" == DUI && Convert.ToInt16(speeding) < 4);
            Console.WriteLine(Qualified);
            Console.ReadLine();

        }
    }
}
