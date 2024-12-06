using System;
using System.Globalization;
namespace OlderPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.SetarDados();
            person2.SetarDados();
            if (person1.Age > person2.Age)
            {
                Console.WriteLine($"{person1.Name} tem {person1.Age} anos portanto é mais velho(a).");
            }
            else if(person2.Age > person2.Age){
                Console.WriteLine($"{person2.Name} tem {person2.Age} anos portanto é mais velho(a).");
            }
            else{
                Console.WriteLine($"{person1.Name} e {person2.Name} tem a mesma idade {person1.Age} anos.");
            }
        }
    }
}