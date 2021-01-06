using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PresentationHost.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Search(string q="",string category="")
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}