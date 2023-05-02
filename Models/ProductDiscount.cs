using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class ProductDiscount : Discount
    {
        public int ProductId { get; set; }

        public ProductDiscount(int productId, int id, double discountValue, DateTime createDate, DateTime validFrom, DateTime validUntil, string? couponCode, int minimumOrderValue, int maximumOrderValue) : base(id, discountValue, createDate, validFrom, validUntil, couponCode, minimumOrderValue, maximumOrderValue)
        {
            ProductId = productId;
        }
    }
}