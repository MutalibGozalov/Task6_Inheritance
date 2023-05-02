using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class CustomerMail : Contact
    {
        public CustomerMail(int id, string title, string mail) : base(id, title)
        {
            this.Mail = mail;
        }
        public string Mail { get; set; } = null!;
    }
}