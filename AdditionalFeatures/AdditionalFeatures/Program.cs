using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace AdditionalFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Matthew Groble";
            Console.WriteLine("Hello {0}. Welcome to the program.", name);
            var student = new Construct(name);            
        }
    }
}
