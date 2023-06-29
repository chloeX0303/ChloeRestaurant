using System.ComponentModel.DataAnnotations;

namespace ChloeRestaurant.Models
{
    public class Food
    {
        public int ID { get; set; }
        [Display(Name = "Foods Name")]
        public string FoodName { get; set; }
        [Display(Name = "Food Price")]
        public int FoodPrice { get; set; }
        public int Quantity { get; set; }
        public ICollection<Order> Orders  { get; set; }
    }
}
