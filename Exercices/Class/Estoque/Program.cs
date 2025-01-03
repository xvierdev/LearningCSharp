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

            Console.WriteLine("Dados do produto: " + produto.ToString());

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados do produto: " + produto.ToString());

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados do produto: " + produto.ToString());

        }

    }
}