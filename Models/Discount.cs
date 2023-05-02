using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class Discount : BaseEntity
    {
        public Discount(int id, double discountValue, DateTime createDate, DateTime validFrom, DateTime validUntil, string? couponCode, int minimumOrderValue, int maximumOrderValue): base(id)
        {
            DiscountValue = discountValue;
            CreateDate = createDate;
            ValidFrom = validFrom;
            ValidUntil = validUntil;
            CouponCode = couponCode;
            MinimumOrderValue = minimumOrderValue;
            MaximumOrderValue = maximumOrderValue;
        }

        public double DiscountValue { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }
        public string? CouponCode { get; set; }
        public int MinimumOrderValue { get; set; }
        public int MaximumOrderValue { get; set; }
    }
}