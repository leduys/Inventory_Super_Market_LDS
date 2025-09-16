

using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        [Display(Name = "Số hoá đơn")]
        public string InvoiceName { get; set; }
        [Display(Name = "Lô hàng")]
        public int ShipmentId { get; set; }
        [Display(Name = "Ngày tạo hoá đơn")]
        public DateTimeOffset InvoiceDate { get; set; }
        [Display(Name = "Ngày hết hạn hoá đơn")]
        public DateTimeOffset InvoiceDueDate { get; set; }
        [Display(Name = "Kiểu hoá đơn")]
        public int InvoiceTypeId { get; set; }
    }
}
