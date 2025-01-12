using System;
namespace DataNascimento{
    class Program{
        static void Main (string[] args){
            Console.Write("Digite sua data de nascimento: dd/mm/yyyy: ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            TimeSpan Idade = DateTime.Now.Subtract(dataNascimento);
            Console.WriteLine(Idade.TotalDays/365);
        }
    }
}