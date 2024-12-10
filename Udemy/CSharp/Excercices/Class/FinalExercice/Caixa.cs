namespace FinalExercice{
    class Caixa{
        public string Nome { get; set; }
        public int Conta { get; set; }
        public double Saldo { get; set; }

        public Caixa(int conta, string name, double saldo){
            Conta = conta;
            Nome = name;
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
            return $"Conta {Conta}, Titular: {Nome}, Saldo: R$ {Saldo:F2}";
        }
    }
}