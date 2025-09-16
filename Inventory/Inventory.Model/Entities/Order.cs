using Inventory.Service.EnumShares;

namespace Inventory.Model.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public OrderType OrderType { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal Tax { get; set; }
        public decimal ShippingCharges { get; set; } // chi phí vận chuyển
        public decimal Total { get; set; }
        public string PromoCode { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        public string Decription { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
