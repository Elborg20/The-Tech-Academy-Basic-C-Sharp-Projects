using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    { 
        string[] Name = { "Joe", "Jim", "Frank", "Craig", "Bobby", "Larry", "Barry"};
        int[] Age = { 24, 19, 25, 36, 31, 42, 12};
        Console.WriteLine("Select an index of the name Array, please select 0-6");
        int Index1 = Convert.ToInt32(Console.ReadLine());
        if (Index1 > 6)
        {
            Console.WriteLine("Select a new index of the name Array, please select 0-6");
            Index1 = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(Name[Index1]);
        Console.ReadLine();
        Console.WriteLine("Select an index from the Age Array, please select 0-6");
        int Index2 = Convert.ToInt32(Console.ReadLine());
        if (Index2 > 6)
        {
            Console.WriteLine("Please select a value between 0-6.");
            Index2 = Convert.ToInt32(Console.ReadLine());            
        }
        Console.WriteLine(Age[Index2]);
        Console.ReadLine();

        List<string> City = new List<string> {"Denver","Boulder","Aspen","Ft. Collins","Nederland","Pueblo"};
        Console.WriteLine("Please enter an index value between 0-5 for the City List");
        int Index3 = Convert.ToInt32(Console.ReadLine());
        if (Index3 > 5)
        {
            Console.WriteLine("Please select a value between 0-5.");
            Index3 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(City[Index3]);
        Console.ReadLine();



    }
}
