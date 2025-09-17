//using Inventory.Model.Entities;
//using Microsoft.AspNetCore.Identity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Inventory.Utility
//{
//    public class RoleInventory : IRoleInventory
//    {
//        private readonly UserManager<AppUser> _userManager;
//        private readonly UserManager<IdentityRole> _roleManager;

//        public RoleInventory(UserManager<AppUser> userManager, UserManager<IdentityRole> roleManager)
//        {
//            _userManager=userManager;
//            _roleManager=roleManager;
//        }

//        public async Task AddRoleAsync(string AppUserId)
//        {
//            var user = await _userManager.FindByIdAsync(AppUserId);
//            var roles = _roleManager.Roles;
//            if(user == null)
//        }

//        public Task CreateNewRoleAsync()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
