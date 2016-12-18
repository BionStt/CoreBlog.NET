using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult SignIn()
        {
            return View();
        }

        [Route("Admin", Name = "Admin")]
        public IActionResult Admin()
        {
            return View();
        }
    }
}
