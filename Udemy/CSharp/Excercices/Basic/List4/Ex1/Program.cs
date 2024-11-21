using System;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());
            for (int i = 1; i < max; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}