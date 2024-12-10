using System;
namespace FinalExercice{
    class Program{
        static void Main(string[] args){
            int num;
            string titular;
            string deposito;
            Caixa caixa;
            Console.WriteLine("Entre com o número da conta: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta: ");
            titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?");
            deposito = Console.ReadLine();
            if (deposito == "s" || deposito == "S"){
                caixa = new(num, titular, double.Parse(Console.ReadLine()));
            }
            else{
                caixa = new(num, titular, 0);
            }
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(caixa.ToString());

            Console.WriteLine("Entre com o valor para depósito: ");
            caixa.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(caixa.ToString());

            Console.WriteLine("Entre com o valor para saque: ");
            caixa.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(caixa.ToString());
        }
    }
}