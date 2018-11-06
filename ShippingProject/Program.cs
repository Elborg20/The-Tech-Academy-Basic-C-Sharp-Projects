using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of your package:");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the packages width?");
                decimal width = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the packages height?");
                decimal height = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the packages length?");
                decimal length = Convert.ToDecimal(Console.ReadLine());
                decimal dimensionTotal = width + length + height;
                if (dimensionTotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    decimal quote = (dimensionTotal * weight / 100);
                    Console.WriteLine("The cost for your package to be shipped = $" + quote);
                    Console.ReadLine();
                }

            }
        }
    }
}