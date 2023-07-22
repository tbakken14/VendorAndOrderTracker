using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;
using System;

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
            new Vendor(name, description);
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