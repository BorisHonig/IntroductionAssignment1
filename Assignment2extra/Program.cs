using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine()) +1;
            Console.WriteLine("Next year you will be " + age, " years old"); 
            Console.ReadKey();

        }
    }
}
