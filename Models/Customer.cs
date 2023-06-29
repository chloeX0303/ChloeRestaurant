using System.ComponentModel.DataAnnotations;

namespace ChloeRestaurant.Models
{
    public class Customer
    {


        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        [Display(Name = "Phone Number")]
        [MaxLength(11)]
        public string PhoneNumber { get; set; }
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")] 
        public string Email { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
