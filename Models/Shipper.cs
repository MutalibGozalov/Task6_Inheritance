using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class Shipper : BaseEntity
    {
        public Shipper(int id, string name, string phone, string shipperMail) : base(id)
        {
            Name = name;
            Phone = phone;
            ShipperMail = shipperMail;
        }

        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string ShipperMail { get; set; } = null!;
    }
}