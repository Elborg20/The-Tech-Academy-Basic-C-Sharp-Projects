using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic
{
    public class Employee <T>
    {
        public List<T> Things { get; set; }

        public void Print(List<T> Things)           
        {
            foreach (T thing in Things)
            {
                Console.WriteLine(thing);
               
            }
            
        }
        
        
        
    }


}
