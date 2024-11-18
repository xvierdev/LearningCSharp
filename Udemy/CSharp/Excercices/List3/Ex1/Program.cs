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
                    Console.WriteLine("Q1");
                }
                else if (x > 0 & y < 0)
                {
                    Console.WriteLine("Q2");
                }
                else if (x < 0 & y < 0)
                {
                    Console.WriteLine("Q3");
                }
                else if (x < 0 & y > 0)
                {
                    Console.WriteLine("Q4");
                }
                input = Console.ReadLine().Split(' ');
                x = double.Parse(input[0]);
                y = double.Parse(input[1]);
            }
        }
    }
}