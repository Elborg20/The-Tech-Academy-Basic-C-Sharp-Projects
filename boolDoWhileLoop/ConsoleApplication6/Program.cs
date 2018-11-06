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
            Console.WriteLine("What are your annual earnings?");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much money would you like to borrow today?");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int quotient = number1 / number2;
            bool Larger = (quotient >= 4);
            do
            {
                switch (quotient)
                {
                    case 0:
                        Console.WriteLine("Your numbers do not qualify.");
                        Console.WriteLine("Please enter a smaller amount for your loan to see if you qualify:");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        quotient = number1 / number2;
                        break;
                    case 1:
                        Console.WriteLine("These numbers do not qualify.");                       
                        Console.WriteLine("Please enter a smaller amount for your loan to see if you qualify:");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        quotient = number1 / number2;
                        break;
                    case 2:
                        Console.WriteLine("These numbers are getting closer but still do not qualify");                  
                        Console.WriteLine("Please enter a smaller amount for your loan to see if you qualify:");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        quotient = number1 / number2;
                        break;
                    case 3:
                        Console.WriteLine("Almost.");
                        Console.WriteLine("Please enter a smaller amount for your loan to see if you qualify: ");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        quotient = number1 / number2;
                        break;

                    default:
                        Console.WriteLine("Congratulations.  Based off your input you are qualified to receive a loan of $" + number2 + ".");
                        Console.ReadLine();
                        Larger = true;
                        break;
                }
            } while (!Larger);
             
            
        }
    }
}
