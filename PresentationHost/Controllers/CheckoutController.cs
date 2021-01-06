using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pillow.Core.ApplicationService;
using Pillow.Core.Entites;

namespace PresentationHost.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly Cart cart;

        public CheckoutController(Cart cart,IOrderService)
        {
            this.cart = cart;
        }
        public IActionResult Index()
        {
            ViewBag.cart = cart;
            return View(new Order());
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Index(Order order)
        {
            if (cart.CartLines.Count() == 0)
            {
                ModelState.AddModelError("", "سفارشی موجود نیست");
            }

            if (ModelState.IsValid)
            {
                order.Lines = cart.CartLines.ToList();
                serv
                cart.Clear();
                return RedirectToAction("Pay", "Payment");
            }
            return View(order);
        }
    }
}