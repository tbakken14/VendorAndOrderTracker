using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/Vendor")]
        public ActionResult NewVendor()
        {
            return View();
        }

        [HttpPost("/Vendor")]
        public ActionResult NewVendor(string name, string description)
        {
            Vendor vendor = new Vendor(name, description);
            Vendor.Vendors.Add(name, vendor);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("/Vendor/{id}")]
        public ActionResult VendorDetails(string id)
        {
            Vendor vendor = Vendor.Vendors[id];
            return View(vendor);
        }
    }
}