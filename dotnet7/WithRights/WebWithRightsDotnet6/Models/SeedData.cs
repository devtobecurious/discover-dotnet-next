using Microsoft.AspNetCore.Identity;
using System.Diagnostics.CodeAnalysis;
using WebWithRightsDotnet6.Areas.Identity.Data;

namespace WebWithRightsDotnet6.Models
{
    public static class SeedData
    {
        public static void Seed<T>([NotNull] this UserManager<T> userManager) where T: IdentityUser, new()
        {
            string email = "evan@boissonnot.fr";

            if (userManager.FindByEmailAsync(email).Result == null)
            {
                T user = new T()
                {
                    UserName = email,
                    Email = email
                };

                IdentityResult result = userManager.CreateAsync(user, "Test123!").Result;
                if (result != null && result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admins").Wait();
                }

                var code = userManager.GenerateEmailConfirmationTokenAsync(user).Result;
                userManager.ConfirmEmailAsync(user, code);
            }
        }

        public static void SeedRoles<T>([NotNull] this RoleManager<T> roleManager) where T : IdentityRole, new()
        {
            string[] roles = new[] { "Admins", "Clients" };

            foreach (var roleName in roles)
            {
                if (! roleManager.Roles.Any(item => item.Name == roleName))
                {
                    var roleToAdd = new T()
                    {
                        Name = roleName,
                    };
                    roleManager.CreateAsync(roleToAdd).Wait();
                }
            }
        }
    }
}
