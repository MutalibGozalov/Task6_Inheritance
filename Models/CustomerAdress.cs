using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class CustomerAdress : Contact
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public int Building { get; set; }
        public int No { get; set; }
    }
}