using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
