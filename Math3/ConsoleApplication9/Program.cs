using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer");
            int input = Convert.ToInt32(Console.ReadLine());
            Integer integer = new Integer();
            integer.Operation(input);
            Console.WriteLine("Please enter a decimal number:");
            Integer integer2 = new Integer();
            double input2 = Convert.ToDouble(Console.ReadLine());
            integer2.Operation(input2);
            Console.WriteLine("Please enter another number:");
            Integer integer3 = new Integer();
            string input3 = Console.ReadLine();
            integer3.Operation(input3);
            
            


        }
    }
}
