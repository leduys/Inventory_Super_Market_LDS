

namespace Inventory.Utility
{
    public interface IRoleInventory
    {
        Task CreateNewRoleAsync();
        Task AddRoleAsync(string AppUserId);
    }
}
