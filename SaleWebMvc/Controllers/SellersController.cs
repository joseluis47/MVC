using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleWebMvc.Service;

namespace SaleWebMvc.Controllers
{
    public class SellersController : Controller
    {
        public SellerService SellerService { get; set; }

        public SellersController(SellerService sellerService)
        {
            SellerService = sellerService;
        }

        
        
        public IActionResult Index()
        {
            var obj = SellerService.FindAll();
            return View(obj);
        }

        public IActionResult Create()
        {
            
            return View();
        }
    }
}
