// Food.cs
namespace FoodOrderApp
{
    public class Food
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageName { get; set; }
        public bool IsAvailable { get; set; }
        public int Quantity { get; set; } // Thêm thuộc tính mới
    }
}