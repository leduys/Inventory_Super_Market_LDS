

using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
    }
}
