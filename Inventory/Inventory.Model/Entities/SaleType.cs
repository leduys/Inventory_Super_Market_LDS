

using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class SaleType
    {
        public int SaleTypeId { get; set; }
        [Required]
        public string SaleTypeName { get; set; }
        public string Description { get; set; }
    }
}
