using ECommerceProject.Business.Abstract;
using ECommerceProject.DataAccess.Concrete;
using ECommerceProject.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ECommerceProject.AdminUI.Controllers
{
    public class UserController : Controller
    {
        private readonly Context _c;
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
            _c = new Context();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var users = _c.Users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            if (users != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
