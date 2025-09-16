

using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class CustomerType
    {
        public int CustomerTypeId { get; set; }
        [Required]
        public string CustomerNameType { get; set; }
        public string Description { get; set; }
    }
}
