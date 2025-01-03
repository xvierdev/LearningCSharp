using System;
using System.Globalization;
namespace SalarioMedio{
    class Program{
        static void Main(string[] args){
            double salarioMedio;
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();
            funcionario1.LoadData();
            funcionario2.LoadData();
            salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2;
            Console.WriteLine("Salário médio dos funcionários é R$ {0}", salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}