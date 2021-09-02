using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int getal1 = rnd.Next(101, 10000);
            int getal2 = rnd.Next(101, 10000);
            int getal3 = rnd.Next(101, 10000);
            int getal4 = rnd.Next(101, 10000);


            Console.WriteLine(getal1);
            Console.WriteLine(getal2);
            Console.WriteLine(getal3);
            Console.WriteLine(getal4);

            int result = getal1 + getal2 + getal3 + getal4;
            string nummer1 = getal1.ToString();
            string nummer2 = getal2.ToString();
            string nummer3 = getal3.ToString();
            string nummer4 = getal4.ToString();
            Console.WriteLine("Press ENTER for sum of numbers");

            Console.ReadKey();

            Console.WriteLine($"{nummer1} + {nummer2} + {nummer3} + {nummer4} = {result}");

            Console.ReadKey();
        }
    }
}
