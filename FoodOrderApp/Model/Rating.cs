using System;

namespace FoodOrderApp
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int RatingValue { get; set; }
        public string Comment { get; set; }
        public DateTime RatingDate { get; set; }
    }
}