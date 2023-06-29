using System.ComponentModel.DataAnnotations;

namespace ChloeRestaurant.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        [Display(Name = "Order Date")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime OrderDate { get; set; }
        [Display(Name = "Order Time")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime OrderTime { get; set; }
        [Display(Name = "Pickup Time")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime PickupTime { get; set; }
        public int CustomerID { get; set; }
        public int FoodID { get; set; }

        public Customer Customer { get; set; } 
        public Food Food { get; set; }
    }
}
