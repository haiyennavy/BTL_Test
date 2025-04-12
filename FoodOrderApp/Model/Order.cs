// Order.cs
using System;
using System.Collections.Generic;

namespace FoodOrderApp
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        // Add this property to Order.cs
        public string CustomerName { get; set; }

        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public string DeliveryAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string PaymentMethod { get; set; }
        public string Notes { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
    }
}