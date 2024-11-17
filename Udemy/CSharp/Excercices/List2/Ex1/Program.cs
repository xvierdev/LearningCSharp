using System;
using System.Globalization;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = int.Parse(Console.ReadLine());
            if(number >= 0){
                Console.WriteLine("NAO NEGATIVO");
            }
            else{
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}