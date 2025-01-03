using System;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int in_range = 0, out_range = 0, quantity = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantity; i++)
            {
                int test = int.Parse(Console.ReadLine());
                if (test >= 10 && test <= 20){
                in_range += 1;
            }
                else
            {
                out_range += 1;
            }
        }
        Console.WriteLine("{0} in", in_range);
        Console.WriteLine("{0} out", out_range);
    }
}
}