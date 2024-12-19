namespace Exercices{
    class Produto{
        public string Nome;
        public double Preco;
        public int Quantidade;

        public override string ToString(){
            return $"{Nome}, $ {Preco:C2}, {Quantidade} unidades, Total: $ {Quantidade * Preco:C2}";
        }
        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }

        public void AdicionarProdutos (int quantity){
            Quantidade += quantity;
        }

        public void RemoverProdutos (int quantity){
            Quantidade -= quantity;
        }
    }
}