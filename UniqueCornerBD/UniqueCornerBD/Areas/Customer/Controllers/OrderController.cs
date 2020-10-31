using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniqueCornerBD.Data;
using UniqueCornerBD.Models;
using UniqueCornerBD.Utility;

namespace UniqueCornerBD.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //Action Method For CHekout
        public IActionResult Checkout()
        {
            return View();
        }
        //post method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(Order anorder)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products != null)
            {
                foreach (var product in products)
                {
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.PorductId = product.Id;
                    anorder.OrderDetails.Add(orderDetails);
                }
            }
            anorder.OrderNo = GetOrderNo();
            _context.orders.Add(anorder);
            await _context.SaveChangesAsync();
            HttpContext.Session.Set("products", new List<Products>());
            return RedirectToAction(nameof(ConfirmOrder));
            return View();
        }

        public string GetOrderNo()
        {
            int rowCount = _context.orders.ToList().Count() + 1;
            return rowCount.ToString("000");
        }

        public async Task<IActionResult> ConfirmOrder()
        {
            return View();
        }



    }
}
