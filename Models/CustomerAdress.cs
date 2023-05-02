using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInheritance.Models
{
    public class CustomerAdress : Contact
    {
        public CustomerAdress(int id, string title, string country, string city, string town, string street, int buildingNo) : base(id, title)
        {
            Country = country;
            City = city;
            Town = town;
            Street = street;
            BuildingNo = buildingNo;
        }

        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Town { get; set; } = null!;
        public string Street { get; set; } = null!;
        public int BuildingNo { get; set; }
    }
}