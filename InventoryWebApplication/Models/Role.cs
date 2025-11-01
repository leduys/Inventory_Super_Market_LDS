using System;

namespace InventoryWebApplication.Models
{
    public static class Role
    {
        /// <summary>
        /// Quản lý nhân sự: có thể quản lý người dùng, sản phẩm, phương thức thanh toán, xem báo cáo, bán hàng và xuất bảng dữ liệu
        /// </summary>
        public const string HrManager = "hr-manager";

        /// <summary>
        /// Quản lý kho: có thể quản lý sản phẩm, xem báo cáo, bán hàng và xuất bảng dữ liệu
        /// </summary>
        public const string StockManager = "stock-manager";

        /// <summary>
        /// Nhân viên bán hàng: chỉ có thể bán sản phẩm
        /// </summary>
        public const string Seller = "seller";

        /// <summary>
        /// Người dùng thông thường (mặc định khi đăng ký tài khoản)
        /// </summary>
        public const string User = "user";

        /// <summary>
        /// Nhóm quyền bao gồm Quản lý nhân sự và Quản lý kho
        /// </summary>
        public const string StockManagerAndAbove = HrManager + "," + StockManager;

        /// <summary>
        /// Nhóm quyền bao gồm Quản lý nhân sự, Quản lý kho và Nhân viên bán hàng
        /// </summary>
        public const string SellerAndAbove = HrManager + "," + StockManager + "," + Seller;

        /// <summary>
        /// Danh sách tất cả các quyền có sẵn, theo thứ tự từ cao đến thấp
        /// </summary>
        public static string[] AvailableRoles => new[] { HrManager, StockManager, Seller, User };

        /// <summary>
        /// Trả về tên quyền được định dạng đẹp hơn (hiển thị ra giao diện)
        /// </summary>
        /// <param name="role">Tên quyền trong cơ sở dữ liệu</param>
        /// <returns>Tên quyền được định dạng</returns>
        public static string GetFormattedName(string role)
        {
            if (string.IsNullOrWhiteSpace(role))
                return "Không xác định";

            return role switch
            {
                HrManager => "Quản lý nhân sự",
                StockManager => "Quản lý kho",
                Seller => "Nhân viên bán hàng",
                User => "Người dùng",
                _ => role // nếu gặp quyền khác không nằm trong danh sách thì vẫn hiển thị tên gốc, tránh lỗi
            };
        }
    }
}
