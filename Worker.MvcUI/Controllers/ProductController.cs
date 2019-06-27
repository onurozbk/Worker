﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Worker.Business.Abstract;
using Worker.Entities.Concrete;
using Worker.MvcUI.Models;

namespace Worker.MvcUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index(int page = 1, int category = 0)
        {
            int pageSize = 10;
          
            var products = _productService.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel
            {
                
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
                PageSize = pageSize,
                CurrenCategory = category,
                CurrentPage = page

            };
            
            return View(model);
        }
    }
}