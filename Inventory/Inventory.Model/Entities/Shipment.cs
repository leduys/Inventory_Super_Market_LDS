using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class Shipment
    {
        public int Id { get; set; }
        [Display(Name = "Tên giao hàng")]
        public string ShipmentName{get;set;}

        [Display(Name = "Đơn hàng bán")]
        public int SaleOrderId { get; set; }
        public SaleOrder SaleOrder { get; set; }

        [Display(Name = "Ngày giao hàng")]
        public DateTimeOffset ShipmentDate { get; set; }

        [Display(Name = "Đơn vị vận chuyển")]
        public string Carrier { get; set; }

        [Display(Name = "Mã vận đơn")]
        public string TrackingNumber { get; set; }

        [Display(Name = "Trạng thái")]
        public string Status { get; set; }
        [Display(Name = "Kiểu giao hàng")]
        public int ShipmentTypeId { get; set; }

        [Display(Name = "Số lượng giao")]
        public double Quantity { get; set; }

        [Display(Name = "Ghi chú")]
        public string Remarks { get; set; }
    }
}
