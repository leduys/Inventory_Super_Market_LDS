using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class PurchaseOrder
    {
        
        public int Id { get; set; }

        [Display(Name = "Tên đơn đặt hàng")]
        public string Name { get; set; }

        [Display(Name = "Chi nhánh")]
        public int BranchId { get; set; }

        [Display(Name = "Nhà cung cấp")]
        public int VendorId { get; set; }

        [Display(Name = "Ngày đặt hàng")]
        public DateTimeOffset DateofOrder { get; set; }

        [Display(Name = "Ngày giao hàng")]
        public DateTimeOffset DateOfDelivery { get; set; }

        [Display(Name = "Loại tiền tệ")]
        public int CurrencyId { get; set; }

        [Display(Name = "Loại đơn mua")]
        public int PurchaseTypeId { get; set; }

        [Display(Name = "Ghi chú")]
        public string Remarks { get; set; }

        [Display(Name = "Số tiền")]
        public double Amount { get; set; }

        [Display(Name = "Tạm tính (Cộng tiền hàng)")]
        public double SubTotal { get; set; }

        [Display(Name = "Giảm giá")]
        public double Discount { get; set; }

        [Display(Name = "Thuế")]
        public double Tax { get; set; }

        [Display(Name = "Tổng cộng")]
        public double Total { get; set; }

        public ICollection<PurChaseOrderLine> PurChaseOrders { get; set; } = new HashSet<PurChaseOrderLine>();
    }
}
