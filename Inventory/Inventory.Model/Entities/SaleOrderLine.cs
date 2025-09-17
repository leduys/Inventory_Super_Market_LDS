using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class SaleOrderLine
    {
        
        public int Id { get; set; }

        public int SaleOrderId { get; set; }

        [Display(Name = "Đơn bán hàng")]
        public SaleOrder SaleOrder { get; set; }

        [Display(Name = "Sản phẩm")]
        public int ProductId { get; set; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        [Display(Name = "Số lượng")]
        public double Quantity { get; set; }

        [Display(Name = "Đơn giá")]
        public double Price { get; set; }

        [Display(Name = "Thành tiền (chưa giảm/thuế)")]
        public double Amount { get; set; }

        [Display(Name = "Tỷ lệ chiết khấu (%)")]
        public double DiscountPercentage { get; set; }

        [Display(Name = "Số tiền chiết khấu")]
        public double DiscountAmount { get; set; }

        [Display(Name = "Tạm tính")]
        public double SubTotal { get; set; }

        [Display(Name = "Thuế suất (%)")]
        public double TaxPercentage { get; set; }

        [Display(Name = "Tiền thuế")]
        public double TaxAmount { get; set; }

        [Display(Name = "Tổng cộng")]
        public double Total { get; set; }
    }
}
