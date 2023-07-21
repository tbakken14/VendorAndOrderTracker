using System;

namespace VendorAndOrderTracker.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }

        public Order()
        {
            Title = "";
            Description = "";
            Price = 0;
            Date = DateTime.UtcNow;
        }

        public Order(string title, string description, double price)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = DateTime.UtcNow;
        }
        public Order(string title, string description,
                     double price, DateTime date)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = date;
        }
    }
}