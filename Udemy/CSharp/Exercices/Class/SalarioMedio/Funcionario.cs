using System;
using System.Globalization;
namespace SalarioMedio{
    class Funcionario{
        public string Name;
        public double Salario;

        public void LoadData(){
            Console.Write("Digite o nome: ");
            Name = Console.ReadLine();
            Console.Write("Digite o salário: ");
            Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }
}