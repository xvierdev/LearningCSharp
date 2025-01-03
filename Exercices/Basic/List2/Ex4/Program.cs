using System;
namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end, time;
            string[] input = Console.ReadLine().Split(' ');
            start = int.Parse(input[0]);
            end = int.Parse(input[1]);

            if(end < start){
                time = 24 - start + end;
            }
            else if (end > start){
                time = end - start;
            }
            else{
                time = 24;
            }

            Console.WriteLine("O JOGO DUROU {0} HORA(S)", time);
        }
    }
}