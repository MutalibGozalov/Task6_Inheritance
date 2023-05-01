using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class CustomerPhone : Contact
    {
        public int AreaCode { get; set; }
        public string Number { get; set; }
    }
}