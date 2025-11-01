using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using InventoryWebApplication.DatabaseContexts;
using InventoryWebApplication.Models.Database;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace InventoryWebApplication.Services.Database
{
    public class UsersService : NameUniqueDatabaseService<User>
    {
        private static readonly Regex PasswordRegex = new("^\\w{4,}$", RegexOptions.Compiled);
        private readonly ILogger<DatabaseService<User>> _logger;

        public UsersService(DatabaseContext databaseContext, ILogger<DatabaseService<User>> logger)
            : base(databaseContext.Users, databaseContext, logger)
        {
            _logger = logger;
        }

        //Kiểm tra password hợp lệ
        public static bool IsPasswordValid([NotNull] string password)
        {
            return PasswordRegex.IsMatch(password);
        }

        // Băm password SHA256
        private static string GetPasswordHashString([NotNull] string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] passwordHash = SHA256.HashData(passwordBytes);
            return Encoding.UTF8.GetString(passwordHash);
        }

        // Lấy user theo tên và mật khẩu (dùng cho login)
        [ItemCanBeNull]
        public async Task<User> GetByNameAndPassword([NotNull] string name, [NotNull] string password)
        {
            string passwordHash = GetPasswordHashString(password);
            string lowerUsername = name.ToLower();

            return await ItemSet.FirstOrDefaultAsync(o =>
                o.Name.ToLower() == lowerUsername &&
                o.Password == passwordHash);
        }

        // Thêm mới (dùng trong Register)
        public async Task<bool> Create([NotNull] User user)
        {
            if (string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.Password))
            {
                _logger.LogWarning("User creation failed: Missing name or password");
                return false;
            }

            if (!IsPasswordValid(user.Password))
            {
                _logger.LogWarning("User creation failed: Password invalid");
                return false;
            }

            // Hash password trước khi lưu
            user.Password = GetPasswordHashString(user.Password);
            bool result = await base.Add(user);
            return result;
        }

        // Tìm user theo tên
        [ItemCanBeNull]
        public async Task<User> GetByName([NotNull] string name)
        {
            string lowerName = name.ToLower();
            return await ItemSet.FirstOrDefaultAsync(o => o.Name.ToLower() == lowerName);
        }

        // Xóa user (giữ nguyên)
        public async Task<bool> Delete(int id, string ignoreName)
        {
            User element = await GetById(id);

            if (element is null)
            {
                _logger.LogWarning("Could not add item to table User. Id not found.");
                return false;
            }

            if (string.Equals(element.Name, ignoreName, StringComparison.OrdinalIgnoreCase))
            {
                _logger.LogWarning("Could not update item on table User. User was ignored");
                return false;
            }

            await base.Delete(element);
            return true;
        }

        // Ghi đè Add() — băm password trước khi thêm
        public override Task<bool> Add(User element)
        {
            element.Password = GetPasswordHashString(element.Password);
            return base.Add(element);
        }

        // Ghi đè cập nhật
        protected override void SetValues(User target, User values)
        {
            target.Name = values.Name;
            if (!string.IsNullOrWhiteSpace(values.Password))
                target.Password = GetPasswordHashString(values.Password);
            target.Role = values.Role;
        }
    }
}
