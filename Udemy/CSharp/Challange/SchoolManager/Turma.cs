using System;
using System.Collections.Generic;
namespace SchoolManager
{
    class Turma
    {
        public string Code;
        public List<Aluno> Alunos = new List<Aluno>();

        public void AddAlunos(string nome, string telefone)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = nome;
            aluno.Telefone = telefone;
            Alunos.Add(aluno);
        }

        public Turma(string code){
            this.Code = code;
        }

    }
}