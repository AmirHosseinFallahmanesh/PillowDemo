using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PresentationHost.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Pay()
        {
            return View();
        }
    }
}