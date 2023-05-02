using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class Order : BaseEntity
    {
        public Order(int id, Customer customer, double orderTotal, double shippingCost, DateTime orderDate, DateTime deliverDate, int shipperId, int customerAdressId, string status) : base(id)
        {
            Customer = customer;
            OrderTotal = orderTotal;
            ShippingCost = shippingCost;
            OrderDate = orderDate;
            DeliverDate = deliverDate;
            ShipperId = shipperId;
            CustomerAdressId = customerAdressId;
            Status = status;
        }

        // public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public double OrderTotal { get; set; }
        public double ShippingCost { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public DateTime DeliverDate { get; set; }
        public int ShipperId { get; set; }
        public int CustomerAdressId { get; set; }
        public string Status { get; set; } = ShippingStatus.OrderReceived;
    }
}