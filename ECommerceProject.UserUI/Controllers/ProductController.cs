using ECommerceProject.Business.Abstract;
using ECommerceProject.UserUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ECommerceProject.UserUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
           
            ProductListViewModel model = new ProductListViewModel
            {
                Products = _productService.GetAllProduct()
    
            };
            return View(model);
        }
    }
}
