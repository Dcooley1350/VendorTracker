using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Date {get; set;}
        public int Id { get; }
        private static List<Order> _orders = new List<Order> {}; 
        public Order(string title, string description, int price, string date)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = date;
            _orders.Add(this);
            Id = _orders.Count;
        }
        public static List<Order> GetAll()
        {
            return _orders;
        }
        public static void ClearAll()
        {
            _orders.Clear();
        }
        public static Order Find(int Id)
        {
            return _orders[Id-1];
        }
    }
}