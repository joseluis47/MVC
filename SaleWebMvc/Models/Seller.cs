using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [Display(Name=" Birth Date")]
        public DateTime BirthDate { get; set; }
        [Display(Name = " Base Salary")]
        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public IEnumerable<SalesRecord> SalesRecord { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name,string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
    }
}
