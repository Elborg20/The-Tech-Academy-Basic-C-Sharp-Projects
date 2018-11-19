using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Now = DateTime.Now;
            Console.WriteLine(Now);
            Console.WriteLine("Please enter an integer:");
            string hoursLater = Console.ReadLine();
            int HoursLater = Convert.ToInt32(hoursLater);
            DateTime twoHoursLater = Now.AddHours(HoursLater);
            Console.WriteLine(twoHoursLater);
            Console.ReadLine();
            
        }


    }
}
