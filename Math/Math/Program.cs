using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a whole number to add 200 to:");
            int valueOne = Convert.ToInt32(Console.ReadLine());

            Integer example = new Integer();
            example.Add(valueOne);

            Console.WriteLine("Pick a whole number to subtract 15 from:");
            int valueTwo = Convert.ToInt32(Console.ReadLine());

            Integer example2 = new Integer();
            example2.Subtract(valueTwo);

            Console.WriteLine("Pick a whole number to multiply by 20");
            int valueThree = Convert.ToInt32(Console.ReadLine());

            Integer example3 = new Integer();
            example3.Product(valueThree);

            Console.ReadLine();

            
           
            
        }


    }
}
