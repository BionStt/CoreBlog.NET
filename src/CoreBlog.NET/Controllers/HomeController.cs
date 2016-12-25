using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CoreBlog.NET.Models.AccountViewModels;

namespace CoreBlog.NET.Controllers
{
    public class HomeController : Controller
    {
        [Route("", Name = "Index")]
        public IActionResult Index()
        {
            return View(); 
        }

        [Route("SignIn", Name = "SignIn")]
        public IActionResult SignIn(string returnUrl = null)
        {
            var model = new LoginViewModel { ReturnUrl = returnUrl };
            return View(model);
        }

        [Authorize]
        [Route("Admin", Name = "Admin")]
        public IActionResult Admin()
        {
            return View();
        }
    }
}
