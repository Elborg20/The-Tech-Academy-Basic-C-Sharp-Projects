using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Integer integer = new Integer();
            Console.WriteLine("Please enter an integer for program: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another integer for the program if you desire:");
            string input2 = (Console.ReadLine());
            if (input2 == string.Empty)
            {
                integer.Product(input1);
            }
            else
            {
                int input3 = Convert.ToInt32(input2);
                integer.Product(input1, input3);
            }
            Console.ReadLine();


        }
    }
}
