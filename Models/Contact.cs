using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class Contact : BaseEntity
    {
        public string? Title { get; set; }

        public Contact(int id, string? title) : base(id)
        {
            Title = title;
        }
    }
}