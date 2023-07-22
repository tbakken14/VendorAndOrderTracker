using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/Vendor")]
        public ActionResult Vendors()
        {
            return View(Vendor.Vendors);
        }

        [HttpGet("/NewVendor")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/NewVendor")]
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