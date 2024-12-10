using System.Globalization;
namespace FinalExercice{
    class ContaBancaria{
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string name){
            Conta = conta;
            Titular = name;
        }
        public ContaBancaria(int conta, string name, double saldo): this(conta, name){
            Saldo = saldo;
        }

        public void Deposito (double amount){
            Saldo += amount;
        }

        public double Saque (double amount){
            if (amount <= Saldo){
                Saldo -= amount;
                return amount;
            }
            else{
                return 0;
            }
        }

        public override string ToString(){
            return $"Conta {Conta}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}