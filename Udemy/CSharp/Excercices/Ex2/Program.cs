using System;
using System.Globalization;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            double area, raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = PI * Math.Pow(raio, 2);
            Console.WriteLine("AREA={0}", area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}