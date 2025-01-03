using System;
namespace OlderPerson
{
    class Person
    {
        public string Name;
        public int Age;
        public void SetarDados()
        {
            try
            {
                Console.WriteLine("Digite o nome: ");
                Name = Console.ReadLine();
                Console.WriteLine("Digite a idade: ");
                Age = int.Parse(Console.ReadLine());
            }
            catch{
                Console.WriteLine("Dados inválid");
            }
        }
    }
}