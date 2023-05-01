using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductSKU { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public int DiscountId { get; set; }
        //public Discount Discount { get; set; }
    }
}