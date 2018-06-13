using AngularASPNETCore2WebApiAuth.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularASPNETCore2WebApiAuth
{
    public class MyIdentityDataInitializer
    {
    public static void SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
    {
      SeedRoles(roleManager);
      SeedUsers(userManager);
    }

    public static void SeedUsers(UserManager<AppUser> userManager)
    {
      if (userManager.FindByNameAsync("user1").Result == null)
      {
        AppUser user = new AppUser();
        user.UserName = "user1";
        user.Email = "user1@localhost";

        IdentityResult result = userManager.CreateAsync(user, "password_goes_here").Result;

        if (result.Succeeded)
        {
          userManager.AddToRoleAsync(user, "NormalUser").Wait();
        }
      }


      if (userManager.FindByNameAsync("user2").Result == null)
      {
        AppUser user = new AppUser();
        user.UserName = "user2";
        user.Email = "user2@localhost";

        IdentityResult result = userManager.CreateAsync(user, "password_goes_here").Result;

        if (result.Succeeded)
        {
          userManager.AddToRoleAsync(user, "Administrator").Wait();
        }
      }
    }

    public static void SeedRoles(RoleManager<AppRole> roleManager)
    {
      if (!roleManager.RoleExistsAsync("NormalUser").Result)
      {
        AppRole role = new AppRole();
        role.Name = "NormalUser";
        IdentityResult roleResult = roleManager.
        CreateAsync(role).Result;
      }


      if (!roleManager.RoleExistsAsync  ("Administrator").Result)
      {
        AppRole role = new AppRole();
        role.Name = "Administrator";
        IdentityResult roleResult = roleManager.
        CreateAsync(role).Result;
      }
    }
  }
}
