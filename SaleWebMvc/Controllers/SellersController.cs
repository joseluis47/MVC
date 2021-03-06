﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleWebMvc.Models;
using SaleWebMvc.Models.ViewModel;
using SaleWebMvc.Service;

namespace SaleWebMvc.Controllers
{
    public class SellersController : Controller
    {
        public SellerService SellerService { get; set; }
        public DepartmentService DepartmentService { get; set; }

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            SellerService = sellerService;
            DepartmentService = departmentService;
        }

        public IActionResult Index()
        {
            var obj = SellerService.FindAll();
            return View(obj);
        }

        public IActionResult Create()
        {
            var ListDepartment = DepartmentService.FindAll();
            var Model = new SellerFormViewModel { Departments = ListDepartment };
            
            return View(Model);
        }
       [HttpPost]
       [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            SellerService.Inserir(seller);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? Id)
        {
           if (Id == null)
            {
                throw new Exception("Sem Id");
            }

            var obj = SellerService.FindById(Id.Value);

            if (obj == null)
            {
                throw new Exception("Sem Id");
            }
            return View(obj);
        }

       [HttpPost]
       [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            try
            {
                SellerService.Excluir(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return RedirectToAction(nameof(Index));
            }
        }


    }
}
