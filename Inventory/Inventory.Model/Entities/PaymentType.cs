

using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class PaymentType
    {
        public int PaymentId { get; set; }
        [Required]
        public string PaymentTypeName { get; set; }
        public string Description { get; set; }
    }
}
