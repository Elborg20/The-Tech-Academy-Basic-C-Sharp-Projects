using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Integer
    {
        public int addend = 20;
        public double multiplier = 8;
        public int divisor = 10;
        public void Operation(int input)
        {
            Console.WriteLine("Your number + 20 = " + (input + addend));
        }
        public void Operation(double input2)
        {
            Console.WriteLine(input2 + " multiplied by 8 and rounded down = " + Convert.ToInt32(multiplier * input2));
        }
        
        public void Operation(string input3)
        {
            try
            {
                Console.WriteLine("That number divided by 10 and rounded down = " + Convert.ToInt32(input3) / divisor);
            }
            catch (FormatException)
            {
                Console.WriteLine("You were supposed to enter an integer");
            }
            finally
            {
                Console.ReadLine();
            }
        }

    }
}
