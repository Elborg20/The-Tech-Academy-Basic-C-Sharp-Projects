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
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder = number % 7;
            bool pass = remainder == 2;
            while (!pass)
            {
                switch (remainder)
                {
                    case 3:
                        Console.WriteLine("Almost!");
                        Console.WriteLine("Guess another number");
                        number = Convert.ToInt32(Console.ReadLine());
                        remainder = number % 7;
                        break;
                    case 1:
                        Console.WriteLine("Almost!");
                        Console.WriteLine("Guess another number");
                        number = Convert.ToInt32(Console.ReadLine());
                        remainder = number % 7;
                        break;
                    case 2:
                        Console.WriteLine("Correct");
                        pass = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        Console.WriteLine("Guess another number");
                        number = Convert.ToInt32(Console.ReadLine());
                        remainder = number % 7;
                        break;
                }
            }
        }
    }
}
