using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class Product : BaseEntity
    {
        public Product(int id, string name, double price, int amount, int unitsInStock, Category? category) : base(id)
        {
            Name = name;
            Price = price;
            Amount = amount;
            UnitsInStock = unitsInStock;
            Category = category;
        }

        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public int Amount { get; set; }
        public int UnitsInStock { get; set; }
        public Category? Category { get; set; }
        // public int CategoryId { get; set; }
    }
}