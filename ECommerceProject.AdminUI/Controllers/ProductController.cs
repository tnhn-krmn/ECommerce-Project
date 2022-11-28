using ECommerceProject.Business.Abstract;
using ECommerceProject.DataAccess.Concrete;
using ECommerceProject.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ECommerceProject.AdminUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        Context _con;
        public ProductController(IProductService productService)
        {
            _productService = productService;
            _con = new Context();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            _productService.ProductAdd(product);
            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _productService.GetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            _productService.ProductUpdate(product);
            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var result = _con.Products.FirstOrDefault(x => x.ProductId == id);
            var product = _productService.ProductDelete(result);
            return RedirectToAction("Index","Home");
        }
    }
}
