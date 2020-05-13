using Projeto_Git.Entities;
using Projeto_Git.Entities.Enums;
using System;

namespace Projeto_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 33,
                Moment = DateTime.Today,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine(order);
        }
    }
}
