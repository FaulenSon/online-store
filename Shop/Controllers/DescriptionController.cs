using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class DescriptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
