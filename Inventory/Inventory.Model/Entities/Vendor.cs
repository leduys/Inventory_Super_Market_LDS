

using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class Vendor
    {
        public int VendorId { get; set; }
        [Required]
        public string VendorName { get; set; }
        [Display(Name = "Kiểu nhà cung cấp")]
        public string VendorTypeId { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "ZipCode")]
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [Display(Name = "Địa chỉ nhà cung cấp   ")]
        public string ContactPerson { get; set; }


    }
}
