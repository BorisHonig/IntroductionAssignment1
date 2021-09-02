using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int result = 0;
            //vier getallen tussen 101 en 10000
            for (int i = 0; i < 8; i++)
            {
                int randomGetal = rnd.Next(101,10000);
                result += randomGetal;
                Console.WriteLine($"Number {i+1} = {randomGetal}");
                
            }
            Console.WriteLine($"Result = {result}");
        }
    }
}
