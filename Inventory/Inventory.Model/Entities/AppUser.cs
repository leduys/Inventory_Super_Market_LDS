using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage = "Bắt buộc phải nhập tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bắt buộc phải nhập thành phố")]
        public string City { get; set; }

        [Required(ErrorMessage = "Bắt buộc phải nhập địa chỉ")]
        public string Address { get; set; }
        public string PinCode { get; set; }
    }
}
