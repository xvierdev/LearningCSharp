using System;
using System.Globalization;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string[] input = Console.ReadLine().Split(' ');
            x = double.Parse(input[0]);
            y = double.Parse(input[1]);
            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x > 0 & y < 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 & y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x < 0 & y > 0)
                {
                    Console.WriteLine("quarto");
                }
                input = Console.ReadLine().Split(' ');
                x = double.Parse(input[0]);
                y = double.Parse(input[1]);
            }
        }
    }
}