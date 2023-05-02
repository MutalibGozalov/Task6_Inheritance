using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class CategoryDiscount : Discount
    {
        public int CategoryId { get; set; }

        public CategoryDiscount(int categoryId, int id, double discountValue, DateTime createDate, DateTime validFrom, DateTime validUntil, string? couponCode, int minimumOrderValue, int maximumOrderValue) : base(id, discountValue, createDate, validFrom, validUntil, couponCode, minimumOrderValue, maximumOrderValue)
        {
            CategoryId = categoryId;
        }
    }
}