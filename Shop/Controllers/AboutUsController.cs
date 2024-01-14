using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            var photo = new UserViewModel();
            return View(photo);
        }
    }
}
