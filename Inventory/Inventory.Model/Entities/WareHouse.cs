

using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class WareHouse
    {
        public int WareHouseId { get; set; }
        [Required]

        public string WarehouseName { get; set; }
        public string Description { get; set; }
        [Display(Name = "Chi Nhánh ")]
        public int BranchId { get; set; }

    }
}
