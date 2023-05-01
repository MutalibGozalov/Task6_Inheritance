using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public double DiscountValue { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }
        public string CouponCode { get; set; }
        public int MinimumOrderValue { get; set; }
        public int MaximumOrderValue { get; set; }
    }
}