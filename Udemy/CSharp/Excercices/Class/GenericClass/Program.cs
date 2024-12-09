using System;
namespace GenericClass{
    class Program{
        static void Main (string[] args){
            Product g = new Product {Id = 1, Name = "teste"};
            Console.WriteLine(g.Name);
            Console.WriteLine(g.Id);
        }
    }
}