using System;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;
            Console.WriteLine("Enter first number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = int.Parse(Console.ReadLine());
            soma = a + b;
            Console.WriteLine("SOMA = " + soma);
        }
    }
}