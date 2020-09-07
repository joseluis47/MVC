using Microsoft.EntityFrameworkCore;
using SaleWebMvc.Data;
using SaleWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvc.Service
{
    public class SellerService
    {
        public SaleWebMvcContext _context { get; private set; }

        public SellerService(SaleWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.OrderBy(p => p.Name).ToList();
        }
        public void Inserir(Seller seller)
        {
            _context.Seller.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(p=>p.Department).FirstOrDefault(p => p.Id == id);
        }

        public void Excluir(int Id)
        {
            var obj = FindById(Id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
