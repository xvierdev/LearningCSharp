using System;
using System.Globalization;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int item, quantity;
            double price = 0.0;
            string[] input = Console.ReadLine().Split(' ');
            item = int.Parse(input[0]);
            quantity = int.Parse(input[1]);

            if (item == 1)
            {
                price = quantity * 4.0;
            }
            else if (item == 2)
            {
                price = quantity * 4.5;
            }
            else if (item == 3)
            {
                price = quantity * 5.0;
            }
            else if (item == 4)
            {
                price = quantity * 2.0;
            }
            else if (item == 5)
            {
                price = quantity * 1.5;
            }

            Console.WriteLine("Total: R$ {0}", price.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}