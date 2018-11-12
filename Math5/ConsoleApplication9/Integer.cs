using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    public class Integer
    {
        public void Divide(int input, out int userInputs)
        {
            userInputs = 0;
            Console.WriteLine(input / 2);
            userInputs++;
        }
        public void Divide(int input, int divisor = 2)
        {
            Console.WriteLine(input / divisor);
        }
    }
}
