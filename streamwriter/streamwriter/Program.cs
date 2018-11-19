using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace streamwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number for use in the program:");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\\Users\\mtgro\\Logs\\log2.txt", input);
            string file = File.ReadAllText(@"C:\\Users\\mtgro\\Logs\\log2.txt");
            Console.WriteLine(file);
        }
    }
}
