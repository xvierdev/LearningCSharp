using System;
using System.Collections.Generic;

namespace SchoolManager
{
    class Program
    {
        static void PrintAll(List<Aluno> alunos)
        {
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine($"{aluno.Nome} {aluno.Telefone}");
            }
        }
        static void Main(string[] args)
        {
            Turma turma = new Turma("t001");
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Escolha uma opção: ");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (op)
                {
                    case 'i':
                        string nome, telefone;
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        telefone = Console.ReadLine();
                        turma.AddAlunos(nome, telefone);
                        break;
                    case 'c':
                        PrintAll(turma.Alunos);
                        break;
                    case 'q':
                        loop = false;
                        break;
                }
            }
        }
    }
}