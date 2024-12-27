using System;
using System.Linq;
namespace Practice{
    class Program{
        static void Main (string[] args){
            Console.WriteLine(Sum(Disassembly(Console.ReadLine())));
        }
        
        static int Sum (int[] vet){
            int sum = 0;
            for(int i = 0; i < vet.Length; i++){
                sum += vet[i];
            }
            return sum;
        }

        static int[] Disassembly(string seq){
            string[] itens = seq.Split(',');
            int[] nums = new int[itens.Length];
            for(int i = 0; i < itens.Length; i++){
                nums[i] = int.Parse(itens[i]);
            }
            return nums;
        }
    }
}