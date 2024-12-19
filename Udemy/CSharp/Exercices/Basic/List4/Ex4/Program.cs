using System;
using System.Globalization;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            for(int i = 0; i < quantity; i++){
                double a, b;
                string[] input = Console.ReadLine().Split(' ');
                a = double.Parse(input[0], CultureInfo.InvariantCulture);
                b = double.Parse(input[1], CultureInfo.InvariantCulture);
                if(b != 0){
                    Console.WriteLine("{0}", a.ToString("F1", CultureInfo.InvariantCulture));
                }
                else{
                    Console.WriteLine("divisao impossivel");
                }
            }
        }
    }
}