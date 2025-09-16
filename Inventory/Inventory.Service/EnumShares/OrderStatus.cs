

namespace Inventory.Service.EnumShares
{
    public enum OrderStatus
    {
       Pending = 0,    // Đơn mới tạo, chờ xử lý
       Confirmed = 1,  // Đã xác nhận
       Processing = 2, // Đang xử lý
       Packed = 3,     // Đang đóng gói
       Shipped = 4,    // Đang vận chuyển
       Delivered = 5,  // Đã giao thành công
       Cancelled = 6,  // Đã Hủy
       Returned = 7,   // Bị trả lại
       Refunded = 8,   // Đã hoàn tiền
       OnHold = 9,     // Tạm dừng để xử lý
       Failed = 10     // Giao dịch thất bại
    }
}
