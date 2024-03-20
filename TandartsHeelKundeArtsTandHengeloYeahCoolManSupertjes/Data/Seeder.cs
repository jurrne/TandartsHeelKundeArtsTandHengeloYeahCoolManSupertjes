using Microsoft.AspNetCore.Identity;
using static System.Formats.Asn1.AsnWriter;
using System.Data;
using Microsoft.EntityFrameworkCore;
using TandartsSuperCool.Models;
using TandartsSuperCool.Constants;

namespace TandartsSuperCool.Data
{
    public static class DbSeeder
    {
        private static readonly ApplicationUser drjansen;
        static DbSeeder() {
             drjansen = new ApplicationUser
            {
                FirstName = "Victor",
                LastName = "Jansen",
                Infix = "van",
                Address = "Hectorstraat 10",
                PostalCode = "4212KL",
                City = "Hengelo",
                DateOfBirth = DateTime.Now,
                HealthInsurer = "Gelderland",
                CustomerNumber = "1",
            };

        }

        public static async Task SeedUser(ApplicationUser user, ApplicationDbContext context, IServiceProvider service, string role)
        {
            service.GetService<UserManager>().Add(user);
        }
        public static async Task SeedUserRoles(IServiceProvider service)
        {
            //Seed Users and user roles

            

            var userManager = service.GetService<UserManager<ApplicationUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();
           await roleManager.CreateAsync(new IdentityRole(Roles.Owner.ToString()));

            var userInDb = await userManager.FindByEmailAsync("Victor.@gmail.com");
            if (userInDb != null)
            {
                await userManager.AddToRoleAsync(userInDb, Roles.Owner.ToString());
            }
        }
                
    }
}
