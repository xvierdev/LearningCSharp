namespace Salario{
    class Funcionario{
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem){
            double prop = porcentagem / 100;
            SalarioBruto += prop * SalarioBruto;
        }

        public override string ToString(){
            return $"{Nome}, $ {SalarioLiquido():C2}";
        }
    }
}