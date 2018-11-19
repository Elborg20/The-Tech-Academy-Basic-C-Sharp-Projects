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
            DateTime twoHoursLater = Now.AddHours(2);
            Console.WriteLine(twoHoursLater);
            Console.ReadLine();
            
        }


    }
}
