using System;
using Corse.Entities;
using Corse.Entities.Enums;

namespace Corse{
    class Program{
        static void Main(string[] args){
            Order order = new Order{
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            OrderStatus os = Enum.Parse<OrderStatus>("Shipped");
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}