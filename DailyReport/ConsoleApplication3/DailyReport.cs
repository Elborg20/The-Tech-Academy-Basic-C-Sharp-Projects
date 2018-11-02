using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("");
            Console.WriteLine("What course are you on?");
            string CurrentCourse = Console.ReadLine();
            Console.WriteLine("What page number are you currently on in " + CurrentCourse + "?");
            string CurrentPage = Console.ReadLine();
            Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\".");
            string NeedHelp = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string Positives = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");
            string Feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string StudyHours = Console.ReadLine();
            Console.WriteLine("Thank you for your answers.  An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
           
        }
    }
}
