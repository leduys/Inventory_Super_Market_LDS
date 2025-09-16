

using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class Bill
    {
        public int BillId { get; set; }
        [Display(Name = "Hoá đơn/ Tên Hoá Đơn")]
        public string BillName { get; set; }
        [Display(Name = "Ghi chú sửa đổi hàng hoá")]
        public int GoodsReviceNoteId { get; set; }
        [Display(Name = "Đơn đặt hàng/giao hàng với nhà cung cấp")]
        public string VendorNumber { get; set; }
        [Display(Name = "Hoá đơn nhà cung cấp")]
        public string VendorInvoiceNumber { get; set; }
        [Display(Name = "Ngày tạo hoá đơn")]
        public DateTimeOffset BillDate { get; set; }
        [Display(Name = "Hiệu lực của hoá đơn")]
        public DateTimeOffset BillDueDate { get; set; }
        [Display(Name = "Kiểu hoá đơn")]
        public int BillTypeId { get; set; }
    }
}
