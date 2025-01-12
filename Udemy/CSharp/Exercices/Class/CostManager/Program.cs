using System;
namespace CostManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        static char Menu()
        {
            while (true)
            {
                char option = ' ';
                Console.WriteLine("Bem vindo ao gerenciador de custos mensais.");
                Console.WriteLine("Escolha uma opção para continuar.\n");
                Console.WriteLine("1 - adicionar conta.");
                Console.WriteLine("2 - alterar conta existente.");
                Console.WriteLine("3 - listar contas.");
                Console.WriteLine("4 - excluir conta.");
                Console.WriteLine("5 - gerar relatório.");
                Console.WriteLine("6 - sair.");
                option = Console.ReadKey().KeyChar;

                if (!"123456".Contains(option))
                {
                    Console.WriteLine("Opção inválida.");
                }
                else{
                    return option;
                }
            }
        }
    }
}