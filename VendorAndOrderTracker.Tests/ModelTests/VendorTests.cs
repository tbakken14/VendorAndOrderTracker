using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests
{
    [TestClass]
    public class VendorTests
    {
        Vendor _vendor = new Vendor("", "");

        [TestMethod]
        [DataRow("Name of vendor")]
        public void Vendor_Name_Set_And_Get_Test(string name)
        {
            _vendor.Name = name;
            Assert.AreEqual(_vendor.Name, name);
        }

        [TestMethod]
        [DataRow("Description of vendor")]
        public void Vendor_Description_Set_And_Get_Test(string description)
        {
            _vendor.Description = description;
            Assert.AreEqual(_vendor.Description, description);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public void Vendor_Orders_Add_Order_Test(int count)
        {
            count = (count < 0) ? 0 : count;
            for (int i = 0; i < count; i++)
            {
                Order order = new Order();
                _vendor.Orders.Add(order);
            }
            Assert.AreEqual(_vendor.Orders.Count, count);
        }
    }
}