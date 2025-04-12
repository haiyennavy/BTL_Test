using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderApp.Model
{
    public class RatingViewModel
    {
        public int RatingID { get; set; }
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FoodName { get; set; }
        public int RatingValue { get; set; }
        public string Comment { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
