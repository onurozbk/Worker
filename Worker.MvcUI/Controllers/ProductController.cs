using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Worker.Business.Abstract;
using Worker.MvcUI.Models;

namespace Worker.MvcUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        private ICustomerService _customerService;
        public ProductController(IProductService productService, ICustomerService customerService)
        {
            _productService = productService;
            _customerService = customerService;
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

            //_productService.Add(new Product { CategoryId=2,UnitPrice=1,UnitInStock=2,ProductName="Bu bir test Ürünüdür2"});
            //_customerService.Add(new Customer { CustomerName = "WBoard Tech", UserName = "Onurozbk", UserPassword = "1234", Mail = "onurozv@gmail.com", CreatedDate = DateTime.Now.Date, UpdatedDate = DateTime.Now.Date });

            return View(model);
        }
    }
}