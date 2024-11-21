using System;
using System.Globalization;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo();
            Triangulo triangulo2 = new Triangulo();
            string[] input = Console.ReadLine().Split(' ');
            triangulo1.A = double.Parse(input[0], CultureInfo.InvariantCulture);
            triangulo1.B = double.Parse(input[1], CultureInfo.InvariantCulture);
            triangulo1.C = double.Parse(input[2], CultureInfo.InvariantCulture);
            Console.WriteLine("AREA DO TRIANGULO = {0}", triangulo1.Area().ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}