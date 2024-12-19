using System;
using System.Globalization;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++){
                Console.WriteLine("{0} {1} {2}", i, Math.Pow(i,2), Math.Pow(i,3));
            }
        }
    }
}