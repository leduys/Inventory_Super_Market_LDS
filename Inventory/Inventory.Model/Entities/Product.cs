
using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string BarCode { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        [Display(Name = "Đơn vị đo lường")]
        public string MeasureUnitId { get; set; }
        public string BuyingPrice { get; set; }
        public string SellingPrice { get; set; }
        [Display(Name = "Đơn vị sản xuất")]
        public string BranchId { get; set; }
        [Display(Name = "Đơn vị tiền tệ")]
        public string CurrencyId { get; set; }
    }
}
