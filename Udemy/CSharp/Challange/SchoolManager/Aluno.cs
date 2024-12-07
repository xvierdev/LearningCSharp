namespace SchoolManager
{
    public class Aluno
    {
        public string Nome;
        public string Telefone;
        public Aluno (string nome, string telefone){
            Nome = nome;
            Telefone = telefone;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}