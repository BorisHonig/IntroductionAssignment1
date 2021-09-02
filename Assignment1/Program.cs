using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabele 'name' is declared here
            string name;

            // read the name of the user and save it in variable 'name'
            Console.WriteLine("Enter your name here");
            name = Console.ReadLine();

            // read the age of the user and save it in variable 'age'
            // (variable 'age' is declared here and immediately given a value)
            Console.WriteLine("Enter your age here");
            string age = Console.ReadLine();


            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);

            Console.ReadLine();
                   

        }
    }
}
