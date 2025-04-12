// OrderDetail.cs
namespace FoodOrderApp
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public string ImageName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal Subtotal
        {
            get { return Quantity * UnitPrice; }
        }
    }
}