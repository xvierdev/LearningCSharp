using System;
using System.Globalization;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            const string senha = "2002";
            string pass = Console.ReadLine();
            while (pass != senha)
            {
                if (pass != senha)
                {
                    Console.WriteLine("Senha Invalida");
                }
                pass = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}