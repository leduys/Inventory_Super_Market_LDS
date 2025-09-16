using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class Branch
    {
        public int BranchId { get; set; }
        [Required]
        public string BranchName { get; set; }
        public string Description { get; set; }

        [Display(Name = "Đơn vị tiền tệ")]
        public int CurrencyId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [Display(Name = "Thông tin người liên hệ")]
        public string ContactPerson { get; set; }

    }
}
