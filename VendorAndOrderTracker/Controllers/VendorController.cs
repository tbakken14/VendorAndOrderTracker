using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/Vendor")]
        public ActionResult Overview()
        {
            return View();
        }

        [HttpGet("/Vendor/New")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/Vendor/New")]
        public ActionResult New(string name, string description)
        {
            Vendor vendor = new Vendor(name, description);
            Vendor.Vendors.Add(vendor);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("/Vendor/{id}")]
        public ActionResult Show(int id)
        {
            Vendor vendor = Vendor.Vendors[id];
            return View(vendor);
        }
    }
}