using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
                string input = Console.ReadLine();

            int wub;
            int age = int.Parse(input);

            // +=1 werkt, ++ werkt niet
            wub = age++;

            
            Console.WriteLine("Next year you will be " + wub +" years old");


            Console.ReadKey();

        }
    }
}
