using System;
using System.Globalization;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qtd;
            double unitPrice, totalPrice = 0;
            for (int i = 0; i < 2; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                cod = int.Parse(input[0]);
                qtd = int.Parse(input[1]);
                unitPrice = double.Parse(input[2], CultureInfo.InvariantCulture);
                totalPrice += qtd * unitPrice;
            }
            Console.WriteLine("VALOR A PAGAR = R$ {0}", totalPrice.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}