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
            string part1 = "Hello, ";
            string part2 = "my name is \"Matt\" ";
            string part3 = "and I like to eat pizza";
            Console.WriteLine(part1 + part2 + part3);
            string upper = part2.ToUpper();
            Console.WriteLine(upper);

            StringBuilder sb = new StringBuilder();
            sb.Append ("\t Welcome to Jurassic Park.  ");
            sb.Append ("We are happy to host you in our Dinosaur Extravaganza.  ");
            sb.Append ("Please be careful on the tour, the birds have been a little stir crazy recently.  ");
            sb.Append("If you are lucky, you may have a chance encounter with our Tyranosaurus Rex.  ");
            sb.Append("Thank you for coming, enjoy!");
            Console.WriteLine(sb);
            Console.ReadLine();

        

               


        }
    }
}
