using System;
namespace ReviewCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Msg msg = new()
            {
                Content = Console.ReadLine(),
                Author = Console.ReadLine()
            };
            bool result = Message(msg);
            if (result){
                Teste t = new()
                {
                    Info = 234M,
                    Arq = "Memory"
                };
                Console.WriteLine($"{t.Info} e {t.Arq}");
            }
        }

        static bool Message(Msg name)
        {
            string message = $@"{name.Content}
            {name.Author}, Feliz Natal!";
            Console.WriteLine(message);
            return true;
        }

        class Msg
        {
            public string Content;
            public string Author{
                get{
                    return Author;
                }
                private set{

                }
            }
        }

        class Teste
        {
            public decimal Info;
            public string Arq;
        }
    }
}