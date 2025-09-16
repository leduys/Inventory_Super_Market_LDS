
using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Display(Name = "Kiểu khách hàng")]
        public int CustomerTypeId { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "ZipCode")]
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [Display(Name = "Thông tin liên lạc của khách hàng")]
        public string ContactPerson { get; set; }


    }
}
