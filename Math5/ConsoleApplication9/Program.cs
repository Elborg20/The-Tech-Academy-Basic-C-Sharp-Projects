using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Integer integer = new Integer();
            int userInputs = 0;
            Console.WriteLine("Please enter an integer:");           
            int input = Convert.ToInt32(Console.ReadLine());
            integer.Divide(input, out userInputs);
            Console.WriteLine(userInputs);
            integer.Divide(input, 4);
            Console.ReadLine();
        }

    }
}