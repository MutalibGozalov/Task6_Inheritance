using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class ProductDiscount : Discount
    {
        public int ProductId { get; set; }
    }
}