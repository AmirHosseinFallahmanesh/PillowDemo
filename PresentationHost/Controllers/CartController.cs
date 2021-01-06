using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pillow.Core.Contracts;
using Pillow.Core.Entites;

namespace PresentationHost.Controllers
{
    public class CartController : Controller
    {
        private readonly IProdctService prodctService;
        private readonly Cart cart;

        public CartController(IProdctService prodctService,Cart cart)
        {
            this.prodctService = prodctService;
            this.cart = cart;
        }
        public IActionResult Index()
        {
            return View(cart);
        }

        public IActionResult AddToCart(int productId,int qunaity)
        {
            string referer = Request.Headers["Referer"].ToString();
            Product product = prodctService.Get(productId);
            if (product!=null)
            {
                cart.AddItem(product, qunaity);
            }
            return Redirect(referer);
        }
    }
}