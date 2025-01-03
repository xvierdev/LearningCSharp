using System;
using System.Collections.Generic;
using System.Globalization;

namespace List1Ex{
    class Program{
        static void Main (string[] args){
            List<Funcionario> fList = [];
            int rep = 0;
            Console.Write("How many employees will be registered? ");
            rep = int.Parse(Console.ReadLine());

            for(int i = 1; i <= rep; i++){
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                int newId = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string newName = Console.ReadLine();
                Console.Write("Salary: ");
                double newSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fList.Add(new Funcionario(newId, newName, newSalary));
                Console.WriteLine();
            }

            Console.Write("Enter that employee id that will have salary increase : ");
            int id = int.Parse(Console.ReadLine());
            Funcionario increase = fList.Find(x => x.Id == id);
            if(increase != null){
                Console.Write("Enter the porcentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                increase.IncreaseSalary(percent);
            }
            else{
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();

            Console.WriteLine("Updated list of employees: ");
            foreach(Funcionario employee in fList){
                Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Salary:F2}", CultureInfo.InvariantCulture);
            }
        }
    }
}