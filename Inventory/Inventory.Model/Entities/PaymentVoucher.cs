

using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class PaymentVoucher
    {
        public int Id { get; set; }
        [Display(Name = "Số chứng từ thanh toán")]
        public string Name { get; set; }
        [Display(Name = "Hoá đơn thanh toán")]
        public int BillId { get; set; }
        public DateTimeOffset PaymetDate { get; set; }
        [Display(Name = "Kiểu thanh toán")]
        public int PaymetTypeId { get; set; }
        public double PaymentAmount { get; set; }
        [Display(Name = "Nguồn thanh toán")]
        public int CashBankId { get; set; }
        [Display(Name = "Trạng thái thanh toán đầy đủ")]
        public bool IsFullPayment { get; set; } = true;

    }
}
