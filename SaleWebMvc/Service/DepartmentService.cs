using SaleWebMvc.Data;
using SaleWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvc.Service
{
    public class DepartmentService
    {
        public SaleWebMvcContext _context { get; private set; }

        public DepartmentService(SaleWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(p => p.Name).ToList();
        }
    }
}
