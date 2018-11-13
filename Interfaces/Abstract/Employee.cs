using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has left the building.");
        }
    }
}
