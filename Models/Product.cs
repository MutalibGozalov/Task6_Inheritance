using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryId { get; set; }
        //public Category Category { get; set; }
    }
}