using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class CategoryDiscount : Discount
    {
        public int CategoryId { get; set; }
    }
}