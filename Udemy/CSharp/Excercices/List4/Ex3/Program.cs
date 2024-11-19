using System;
using System.Globalization;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd;
            double a, b, c;
            qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                double average;
                string[] input = Console.ReadLine().Split(' ');
                a = double.Parse((input[0]), CultureInfo.InvariantCulture);
                b = double.Parse((input[1]), CultureInfo.InvariantCulture);
                c = double.Parse((input[2]), CultureInfo.InvariantCulture);
                average = (2 * a + 3 * b + 5 * c) / 10;
                Console.WriteLine("{0}", average.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}

// 6.5 4.3 6.2 
// 5.1 4.2 8.1 
// 8.0 9.0 10.0