using System;
using System.Globalization;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = 0;
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(salary < 2000){
                Console.WriteLine("Isento");
            }
            else if(salary < 3000){
                tax = (salary - 2000) * 0.08;
            }
            else if(salary < 4500){
                tax += 1000 * 0.08;
                tax += (salary - 3000) * 0.18;
            }
            else{
                tax += 1000 * 0.08;
                tax += 1500 * 0.18;
                tax += (salary - 4500) * 0.28;
            }

            Console.WriteLine("R$ {0}", tax.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}