using System;
using System.Globalization;
namespace FinalExercice{
    class Program{
        static void Main(string[] args){
            int num;
            string titular;
            char deposito;
            double amount;

            ContaBancaria conta;
            Console.Write("Entre com o número da conta: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            deposito = char.Parse(Console.ReadLine());
            if (deposito == 's' || deposito == 'S'){
                amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new(num, titular, amount);
            }
            else{
                conta = new(num, titular, 0.0);
            }
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta.ToString());
            Console.WriteLine();

            Console.WriteLine("Entre com o valor para depósito: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(amount);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta.ToString());
            Console.WriteLine();

            Console.WriteLine("Entre com o valor para saque: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(amount);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta.ToString());
        }
    }
}