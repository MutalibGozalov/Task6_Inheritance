using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class Customer : BaseEntity
    {
        public Customer(int id, string firstName, string lastName, CustomerAdress? customerAdress, CustomerMail customerMail, CustomerPhone? customerPhone) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            CustomerAdress = customerAdress;
            CustomerMail = customerMail;
            CustomerPhone = customerPhone;
        }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public CustomerAdress? CustomerAdress { get; set; }
        public CustomerMail CustomerMail { get; set; } = null!;
        public CustomerPhone? CustomerPhone { get; set; }
        // public int AdressId { get; set; }
        // public int MailAdressId { get; set; }
        // public int PhoneId { get; set; }
    }
}