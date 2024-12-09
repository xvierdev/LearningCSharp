using System;
namespace GenericClass{
    class Program{
        static void Main (string[] args){
            Generic g = new(1, "sapopema");
            Console.WriteLine(g.GetName());
        }
    }
}