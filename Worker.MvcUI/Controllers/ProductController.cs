using Microsoft.AspNetCore.Mvc;
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
        private ICustomerService _customerService;
        private IActivityService _activityService;

        public ProductController(ICustomerService customerService, IProductService productService, IActivityService activityService)
        {
            _productService = productService;
            _customerService = customerService;
            _activityService = activityService;
        }
        public ActionResult Index(int page = 1, int category = 0)
        {
            var product = _productService.GetById(1);
            //var customer = _customerService.GetById(1);
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
            //var data = _customerService.GetById(10);
            //_productService.Add(new Product { CategoryId=2,UnitPrice=1,UnitInStock=2,ProductName="Bu bir test Ürünüdür2"});
            //_customerService.Add(new Customer { CustomerName = "WBoard Tech", UserName = "Onurozbk", UserPassword = "1234", Mail = "onurozv@gmail.com", CreatedDate = DateTime.Now.Date, UpdatedDate = DateTime.Now.Date });
            _activityService.Add(new Activity { CustomerId = 1, ActivitytDescription = "Test amaçlı açıldı kardo", CreatedDate = DateTime.Now.Date, UpdatedDate = DateTime.Now.Date });
            return View(model);
        }
    }
}