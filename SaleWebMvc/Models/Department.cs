using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvc.Models
{
    public class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public IEnumerable<Seller> Sellers = new List<Seller>();

        public Department( int id, string name)
        {
            Name = name;
            Id = id;
        }

        public Department()
        {
        }
    }
}
