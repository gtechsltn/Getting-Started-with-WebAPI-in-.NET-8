using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Services
{
    public class MyService : IMyService
    {

        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 999.99m },
            new Product { Id = 2, Name = "Smartphone", Price = 599.99m }
        };

        public List<Product> GetAll()
        {

            return products;
        }


    }
}
