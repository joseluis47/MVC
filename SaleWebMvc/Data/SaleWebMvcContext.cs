﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaleWebMvc.Models;

namespace SaleWebMvc.Data
{
    public class SaleWebMvcContext : DbContext
    {
        public SaleWebMvcContext (DbContextOptions<SaleWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SaleWebMvc.Models.Department> Department { get; set; }
        public DbSet<SaleWebMvc.Models.Seller> Seller { get; set; }
        public DbSet<SaleWebMvc.Models.SalesRecord> SalesRecord { get; set; }
    }
}
