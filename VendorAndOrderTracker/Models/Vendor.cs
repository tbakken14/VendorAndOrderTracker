using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
    public class Vendor
    {
        public static List<Vendor> Vendors { get; } = new List<Vendor>();
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> Orders { get; set; }

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            Orders = new List<Order>();
        }
    }
}