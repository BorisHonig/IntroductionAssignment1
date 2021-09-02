using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
                string input = Console.ReadLine();


            int age = int.Parse(input);

            // +=1 werkt, ++ werkt niet
            age = age +1;

            string output = age.ToString();

            Console.WriteLine("Next year you will be " + age +" years old");


            Console.ReadKey();

        }
    }
}
