using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math2
{
    class Program
    {
        static void Main(string[] args)
        {
            Integer example = new Integer();
            Console.WriteLine("Please enter an integer for the program");
            int valueOne = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Please enter another number for the program:");
            int valueTwo = Convert.ToInt32(Console.ReadLine());
            example.Product(valueOne, valueTwo);

        }
    }
}
