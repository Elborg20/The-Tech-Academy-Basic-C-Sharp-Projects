using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math
{
    public class Integer
    {
        public int firstNumber = 200;
        public int secondNumber = 15;
        public int thirdNumber = 20;

        public void Add(int valueOne)
        {
            Console.WriteLine(firstNumber + valueOne);
        }
        public void Subtract(int valueTwo)
        {
            Console.WriteLine(valueTwo - secondNumber);
        }
        public void Product(int valueThree)
        {
            Console.WriteLine(thirdNumber * valueThree);
        }
               


    }


}
