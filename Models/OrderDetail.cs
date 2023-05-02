using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class OrderDetail  : BaseEntity
    {
        public OrderDetail(int id, int orderId, int productId, string productSKU, double price, int count, Discount? discount) : base(id)
        {
            OrderId = orderId;
            ProductId = productId;
            ProductSKU = productSKU;
            Price = price;
            Count = count;
            Discount = discount;
        }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductSKU { get; set; } = null!;
        public double Price { get; set; }
        public int Count { get; set; }
        public Discount? Discount { get; set; }
         // public int DiscountId { get; set; }
    }
}