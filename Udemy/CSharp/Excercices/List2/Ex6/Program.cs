using System;
using System.Globalization;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num <= 25)
            {
                if (num > 0)
                {
                    Console.WriteLine("Intervalo [0, 25]");
                }
                else
                {
                    Console.WriteLine("Fora de intervalo");

                }
            }
            else if (num <= 50)
            {
                Console.WriteLine("Intervalo (25, 50]");
            }
            else if (num <= 75)
            {
                Console.WriteLine("Intervalo (50, 75]");
            }
            else if (num <= 100)
            {
                Console.WriteLine("Intervalo (75, 100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}