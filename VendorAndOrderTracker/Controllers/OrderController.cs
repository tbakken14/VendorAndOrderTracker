using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("/Vendor/{vid}/NewOrder")]
        public ActionResult New(int vid)
        {
            Vendor vendor = Vendor.Vendors[vid];
            return View(new { vendor = vendor, id = vid });
        }

        [HttpPost("/Vendor/{vid}/NewOrder")]
        public ActionResult New(int vid, string title, string description, double price)
        {
            Vendor vendor = Vendor.Vendors[vid];
            Order order = new Order(title, description, price);
            vendor.Orders.Add(order);
            return RedirectToAction("Show", "Vendor", new { id = vid });
        }

        [HttpGet("/Vendor/{vid}/Order/{oid}")]
        public ActionResult Show(int vid, int oid)
        {
            Vendor vendor = Vendor.Vendors[vid];
            Order order = Vendor.Vendors[vid].Orders[oid];
            return View(new { vendor = vendor, order = order });
        }
    }
}