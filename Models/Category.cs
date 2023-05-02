using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class Category : BaseEntity
    {
        public Category(int id, string name, string? description, Product[] products) : base(id)
        {
            Name = name;
            Description = description;
            Products = products;
        }

        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public Product[] Products { get; set; }  = null!;
    }
}