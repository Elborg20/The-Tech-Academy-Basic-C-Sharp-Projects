using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    public class Integer
    {
        int multiply = 3;
        public void Product (int input1, int input3 = 3)
        {
            Console.WriteLine("Your first number * your second number = " + (input1 * input3));
            Console.WriteLine("If no second number was entered, you will see your first number * 3");
        }
      
    }
}
