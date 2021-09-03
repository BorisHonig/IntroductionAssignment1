using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of numbers: "); string amount = Console.ReadLine();
            int hoeveelheid = int.Parse(amount);
            Random rnd = new Random();
            int result = 0;
            int getallen = 0;
            //getallen tussen 101 en 10000
            for (int i = 0; i < hoeveelheid; i++)
            {
                int randomGetal = rnd.Next(101, 10000);
                result += randomGetal;
                Console.WriteLine($"Number {i + 1} = {randomGetal}");
                Console.ReadKey();
                if (i <= hoeveelheid)  ;
            }


            Console.WriteLine($"Result = {getallen} + {getallen} + {result}");
        }
    }
}
