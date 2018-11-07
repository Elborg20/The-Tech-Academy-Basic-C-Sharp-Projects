using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            //drill 1 - 1-D string array

            //string[] Words = { "Learn", "To", "Code", "One", "Day", "At", "A", "Time" };
            //for (int i = 0; i < Words.Length; i++)
            //{
            //    Words[i] = (Words[i] + "Tech");
            //}
            //for (int j = 0; j<Words.Length; j++)
            //{
            //    Console.WriteLine(Words[j]);               
            //}
            //Console.ReadLine();


            // drill 2 infinite loop

            //for (int k = 1; k > 0; k++)
            //{
            //    Console.WriteLine("Diamonds are Forever");
            //}


            //drill 3 - fixed loop

            //for (int l=0; l < 5; l++)
            //{
            //    Console.WriteLine("Diamonds are sometimes Forever");
            //}
            //Console.ReadLine();


            //drill 4 create loop with comparison operator <

            //string[] Names = { "Joe", "Johnny", "Jeff", "James", "Greg", "Gary", "George", "Gretzel" };
            //for (int m = 0; m < Names.Length; m++)
            //{
            //    Console.WriteLine(Names[m]);
            //}
            //Console.ReadLine();


            //drill 5 Loop with comparison operator <=

            //int[] testScores = { 65, 75, 85, 85, 54, 32, 64, 92, 95 };
            //for (int i=0; i <= testScores.Length; i++)
            //{
            //    if (testScores[i] >= 85)
            //    {
            //        Console.WriteLine("Passing Score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();


            //drill 6

            //List<string> Names = new List<string>() { "Matt", "Mary", "Marcy", "Jerry", "Jesse", "Jeffrey" };
            //Console.WriteLine("Please input a 2-3 letter string to find similar names:");
            //string search = Console.ReadLine();
            //for (int n = 0; n < Names.Count; n++)
            //{ 
            //    if (Names[n].Contains(search))
            //    {
            //        Console.WriteLine(n);
            //    }
            //}
            //Console.ReadLine();

            //drill 7

            //List<string> Names = new List<string>() { "Matt", "Mary", "Marcy", "Jerry", "Jesse", "Jeffrey" };
            //Console.WriteLine("Please input a 2-3 letter string to find similar names:");
            //string search = Console.ReadLine();
            //int k = 0;
            //for (int n = 0; n < Names.Count; n++)

            //{
            //    if (Names[n].Contains(search))
            //    {
            //        Console.WriteLine(n);
            //        k = k + 1;
            //    }
            //}
            //if (k == 0)
            //{
            //    Console.WriteLine("String not found.");
            //}
            //Console.ReadLine();


            //drill 8

            //List<string> Names = new List<string>() { "Matt", "Mary", "Marcy", "Jerry", "Jesse", "Jeffrey" };
            //Console.WriteLine("Please input a letter string to find a similar name:");
            //string search = Console.ReadLine();
            //int k = 0;
            //for (int n = 0; n < Names.Count; n++)
            //{
            //    if (k < 1)
            //    {

            //        if (Names[n].Contains(search))
            //        {
            //            Console.WriteLine(n);
            //            k = k + 1;
            //        }
            //    }
            //}
            //if (k == 0)
            //{
            //    Console.WriteLine("String not found.");
            //}
            //Console.ReadLine();


            //Drill 9

            //List<string> Names = new List<string>() { "Matt", "Mary", "Marcy", "Jerry", "Jesse", "Jeffrey", "Matt" };
            //Console.WriteLine("Please enter a text string to search for:");
            //string search = Console.ReadLine();
            //for (int i = 0; i < Names.Count; i++)
            //{
            //    if (Names[i].Contains(search))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();


            //Drill 10

            //List<string> Names = new List<string>() { "Matt", "Mary", "Marcy", "Jerry", "Jesse", "Jeffrey", "Matt" };
            //Console.WriteLine("Please input a letter string to find similar names:");
            //string search = Console.ReadLine();
            //int k = 0;
            //for (int n = 0; n < Names.Count; n++)

            //{
            //    if (Names[n].Contains(search))
            //    {
            //        Console.WriteLine(n);
            //        k = k + 1;
            //    }
            //}
            //if (k == 0)
            //{
            //    Console.WriteLine("String not found.");
            //}
            //Console.ReadLine();


            //Drill 11

            //List<string> Names = new List<string>() { "Matt", "Mary", "Marcy", "Jerry", "Jesse", "Jeffrey", "Matt" };
            //Console.WriteLine("Please input a 2-3 letter string to find similar names:");
            //int k = -1;
            //foreach (string name in Names)
            //{
            //    k = k + 1;
            //    Console.WriteLine(name);
            //    for (int i = 0; i < k; i++)
            //    {
            //        if (Names[i] == name)
            //        {
            //            Console.WriteLine(" Already Appeared");
            //        }                                                                       
            //    }

            //}
            //Console.ReadLine();
        }
    }
}

