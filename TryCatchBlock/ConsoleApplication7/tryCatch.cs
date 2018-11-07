using System;
using System.Collections.Generic;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> Ages = new List<int>() { 15, 25, 32, 27, 30, 25 };
                Console.WriteLine("Please pick an integer to divide some numbers by, all quotients will be rounded down");
                int divisor = Convert.ToInt32(Console.ReadLine());
                foreach (int age in Ages)
                {
                    int quotient = age / divisor;
                    Console.WriteLine(age + " / " + divisor + " = " + quotient);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter an integer next time.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please pick a number other than zero.");
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
