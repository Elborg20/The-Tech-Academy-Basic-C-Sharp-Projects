using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserDOB
{
    public class Program
    {
        static void Main(string[] args)
        {      
            try
            {
            Console.WriteLine("Please enter your age in integer format, round up if you have not celebrated your birthday this calendar year.");
            int age = int.Parse(Console.ReadLine());
            while (age <= 0)
            {
                Console.WriteLine("Age must be greater than 0.  Please enter an integer greater than 0");
                age = int.Parse(Console.ReadLine());
            }           
            int currentYear = 2018;           
            Console.WriteLine(currentYear - age);
            Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an integer value greater than 0.");
                int currentyear = 2018;
                int newage = int.Parse(Console.ReadLine());
                Console.WriteLine("You were born in " + (currentyear - newage));
                Console.ReadLine();
            }
        }
    }
}
