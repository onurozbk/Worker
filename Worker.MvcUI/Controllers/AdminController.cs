using Microsoft.AspNetCore.Mvc;
using Worker.Business.Abstract;
using Worker.MvcUI.Models;

namespace Worker.MvcUI.Controllers
{
    public class AdminController : Controller
    {
        IProductService _productService;
        public AdminController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }
    }
}