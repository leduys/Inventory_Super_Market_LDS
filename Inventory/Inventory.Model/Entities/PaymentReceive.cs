
using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class PaymentReceive
    {
        public int Id { get; set; }
        [Display(Name = "Biên lai thu tiền")]
        public string Name { get; set; }
        [Display(Name = "Hóa đơn đã thanh toán")]
        public int InvoiceId { get; set; }
        [Display(Name = "Ngày thanh toán")]
        public DateTimeOffset DateOfPayment { get; set; }
        [Display(Name = "Kiểu thanh toán")]
        public int PaymentTypeId { get; set; }
        [Display(Name = "Tổng tiền thanh toán")]
        public double PaymentAmount { get; set; }
        [Display(Name = "Thanh toán hoàn thành?")]
        public bool IsFullPayment { get; set; } = true;


    }
}
