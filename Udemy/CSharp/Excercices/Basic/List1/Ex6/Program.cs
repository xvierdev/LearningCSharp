using System;
using System.Globalization;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            const double PI = 3.14159;
            string[] input = Console.ReadLine().Split(' ');
            A = double.Parse(input[0], CultureInfo.InvariantCulture);
            B = double.Parse(input[1], CultureInfo.InvariantCulture);
            C = double.Parse(input[2], CultureInfo.InvariantCulture);

            Console.WriteLine("TRIANGULO: {0}", (A * C / 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: {0}", (PI * Math.Pow(C, 2)).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: {0}", ((A + B) / 2 * C).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: {0}", Math.Pow(B, 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: {0}", (A * B).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}