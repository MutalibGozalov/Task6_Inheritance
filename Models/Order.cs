using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        //public Customer Customer { get; set; }
        public double OrderTotal { get; set; }
        public double ShippingCost { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliverDate { get; set; }
        public int ShipperId { get; set; }
        public int CustomerAdressId { get; set; }
        public ShippingStatus Status { get; set; }
    }
}