using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name ");
            string firstName = Console.ReadLine();


            Console.Write("Enter your last name ");
            string lastName = Console.ReadLine();


            Console.WriteLine("your full name is " + firstName + " " + lastName);

            //Verander {1} {0} naar {0} {1}
            Console.WriteLine("Your full name is {0} {1}", firstName, lastName);

            Console.WriteLine($"Your full name is {firstName} {lastName}");

            Console.ReadKey();

        }
    }
}
