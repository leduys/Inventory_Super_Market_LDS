using Inventory.Model.Entities;
using Microsoft.AspNetCore.Identity;


namespace Inventory.Utility
{
    internal class DbInitializer
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly UserManager<IdentityRole> _roleManager;
    }
}
