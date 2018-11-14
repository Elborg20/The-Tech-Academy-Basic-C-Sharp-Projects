using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enums
{
    class Program
    {
        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main()
        {
            Console.WriteLine("Please enter the current day of the week.");
            string input = Console.ReadLine();
            Days day;
            try
            {
                day = (Days)Enum.Parse(typeof(Days), input);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter the actual day of the week:");
            }
            Console.ReadLine();

        }
    }
}
