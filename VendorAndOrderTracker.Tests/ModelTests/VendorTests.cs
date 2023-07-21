using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests
{
    [TestClass]
    public class VendorTests
    {
        Vendor _vendor = new Vendor("", "");
        [TestMethod]
        public void Vendor_Name_Set_And_Get_Test(string name)
        {
            _vendor.Name = name;
            Assert.AreEqual(_vendor.Name, name);
        }

        [TestMethod]
        public void Vendor_Description_Set_And_Get_Test(string description)
        {
            _vendor.Description = description;
            Assert.AreEqual(_vendor.Description, description);
        }

        [TestMethod]
        public void Vendor_Orders_Set_And_Get_Test(Order order, int count)
        {
            _vendor.Orders.Add(order);
            Assert.AreEqual(_vendor.Orders.Count, count);
            Assert.AreEqual(_vendor.Orders[_vendor.Orders.Count - 1], order);
        }
    }
}