using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AdressId { get; set; }
        public int MailAdressId { get; set; }
        public int PhoneId { get; set; }
        // public CustomerAdress CustomerAdress { get; set; }
        // public CustomerMail CustomerMail { get; set; }
        // public CustomerPhone CustomerPhone { get; set; }
    }
}