using Microsoft.AspNetCore.Identity;
using TandartsSuperCool.Models;
using TandartsSuperCool.Constants;
using static System.Formats.Asn1.AsnWriter;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TandartsSuperCool.Data
{
    public static class DbSeeder
    {
        private static readonly ApplicationUser user;
        static DbSeeder()
        {
            user = new ApplicationUser
            {
                FirstName = "Victor",
                LastName = "Jansen",
                Email = "DrJansen@gmail.com",
                Address = "Hectorstraat 10",
                PostalCode = "4212KL",
                City = "Hengelo",
                DateOfBirth = DateTime.Now,
            };
        }

        public static async Task SeedUser(IServiceProvider service)
        {
            var userManager = service.GetRequiredService<UserManager<ApplicationUser>>();
            var userStore = service.GetRequiredService<IUserStore<ApplicationUser>>();

            if (await userManager.FindByEmailAsync(user.Email) == null)
            {
                await userStore.SetUserNameAsync(user, user.Email, CancellationToken.None);
                var result = await userManager.CreateAsync(user, "Admin123!");

                if (result.Succeeded)
                {
                    await userManager.ConfirmEmailAsync(user, await userManager.GenerateEmailConfirmationTokenAsync(user));
                    await userManager.AddToRoleAsync(user, "Owner");
                }
            }
        }

        public static async Task SeedUserRoles(IServiceProvider service)
        {
            //Seed user roles
            var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();
            var roles = new[] { "Owner", "Patient", "Dentist", "DentistAssistant" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }

            }
        }
    }
}
