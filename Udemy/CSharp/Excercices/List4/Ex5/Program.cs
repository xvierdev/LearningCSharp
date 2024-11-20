using System;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int fat = 1, number = int.Parse(Console.ReadLine());
            for(int i = 2; i <= number; i++){
                fat *= i;
            }
            Console.WriteLine(fat);
        }
    }
}