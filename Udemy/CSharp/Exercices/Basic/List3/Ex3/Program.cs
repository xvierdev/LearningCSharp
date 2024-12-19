using System;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int gas = 0, alc = 0, die = 0;
            int code = int.Parse(Console.ReadLine());
            while (true)
            {
                code = int.Parse(Console.ReadLine());
                if (code == 1)
                {
                    gas += 1;
                }
                else if (code == 2)
                {
                    alc += 1;
                }
                else if (code == 3)
                {
                    die += 1;
                }
                else if (code == 4)
                {
                    break;
                }
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Gasolina: {0}", gas);
            Console.WriteLine("Alcool: {0}", alc);
            Console.WriteLine("Diesel: {0}", die);

        }
    }
}