using System;
using System.Globalization;

namespace Exercices{
    class Program{
        static void Main (string[] args){
            int number, hours;
            double hourPrice, salary;
            number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            hourPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salary = (double) hours * hourPrice;
            Console.WriteLine("NUMBER = {0}", number);
            Console.WriteLine("SALARY = U$ {0}", salary.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}