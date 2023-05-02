using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class CustomerPhone : Contact
    {
        public CustomerPhone(int id, string title, int areaCode, string number) : base(id, title)
        {
            AreaCode = areaCode;
            Number = number;
        }

        public int AreaCode { get; set; }
        public string Number { get; set; } = null!;
    }
}