using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
    [TestClass]
    public class OrderTests
    {
        Order _order = new Order();
        [TestMethod]
        [DataRow("Title of Order")]
        public void Order_Title_Set_And_Get_Test(string title)
        {
            _order.Title = title;
            Assert.AreEqual(_order.Title, title);
        }

        [TestMethod]
        [DataRow("Description of Order")]
        public void Order_Description_Set_And_Get_Test(string description)
        {
            _order.Description = description;
            Assert.AreEqual(_order.Description, description);
        }

        [TestMethod]
        [DataRow(1.1)]
        public void Order_Price_Set_And_Get_Test(double price)
        {
            _order.Price = price;
            Assert.AreEqual(_order.price, price);
        }

        [TestMethod]
        public void Order_Date_Set_And_Get_Test()
        {
            DateTime date = new DateTime().Date;
            _order.Date = date;
            Assert.AreEqual(_order.Date, date);
        }
    }
}