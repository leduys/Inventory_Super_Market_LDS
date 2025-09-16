namespace Inventory.Service.EnumShares
{
    public enum EnumStatusItem
    {
        Available = 0, // còn hàng
        Out_Of_Stock = 1, // Hết hàng
        Reserved = 2, // Đã giữ cho đơn hàng nào đó
        Damaged = 3, // Hỏng
        Returned = 4, // Hoàn hàng
        Disposed = 5, // Loại bỏ 

    }
}
