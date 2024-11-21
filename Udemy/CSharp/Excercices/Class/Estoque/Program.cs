using System;
using System.Globalization;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade do produto: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            PrintEstoque(produto);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

            PrintEstoque(produto);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));

            PrintEstoque(produto);

        }

        static void PrintEstoque (Produto prod){
            Console.WriteLine("Dados do produto: {0}, $ {1}, {2} unidades, Total: $ {3}", prod.Nome, prod.Preco.ToString("F2", CultureInfo.InvariantCulture), prod.Quantidade, prod.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}