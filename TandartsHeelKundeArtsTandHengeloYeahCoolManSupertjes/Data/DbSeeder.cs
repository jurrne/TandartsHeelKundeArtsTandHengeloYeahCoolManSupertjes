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
        private static readonly ApplicationUser dentist;
        private static readonly ApplicationUser assistant;
        private static readonly ApplicationUser patient;


        static DbSeeder()
        {
            // Dr jansen
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

            // Dentist
            dentist = new ApplicationUser
            {
                FirstName = "Tandarts",
                LastName = "Hans",
                Email = "tandarts_hans@gmail.com",
                Address = "Hectorstraat 11",
                PostalCode = "4213KL",
                City = "Hengelo",
                DateOfBirth = DateTime.Now,
            };

            // Dentist Assistant
            assistant = new ApplicationUser
            {
                FirstName = "Tandarts",
                LastName = "Assistent",
                Email = "tandarts_assistent@gmail.com",
                Address = "Hectorstraat 12",
                PostalCode = "4214KL",
                City = "Hengelo",
                DateOfBirth = DateTime.Now,
            };

            patient = new ApplicationUser
            {
                FirstName = "Patient",
                LastName = "Frans",
                Email = "patient_frans@gmail.com",
                Address = "Hectorstraat 13",
                PostalCode = "4215KL",
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
                // Dr Jansen
                await userStore.SetUserNameAsync(user, user.Email, CancellationToken.None);
                var result = await userManager.CreateAsync(user, "Admin123!");

                if (result.Succeeded)
                {
                    // Dr Jansen
                    await userManager.ConfirmEmailAsync(user, await userManager.GenerateEmailConfirmationTokenAsync(user));
                    await userManager.AddToRoleAsync(user, "Owner");
                }
            }

            if (await userManager.FindByEmailAsync(dentist.Email) == null)
            {
                // Dentist
                await userStore.SetUserNameAsync(dentist, dentist.Email, CancellationToken.None);
                var result = await userManager.CreateAsync(dentist, "Dentist123!");

                if (result.Succeeded)
                {
                    await userManager.ConfirmEmailAsync(dentist, await userManager.GenerateEmailConfirmationTokenAsync(dentist));
                    await userManager.AddToRoleAsync(dentist, "Dentist");
                }
            }

            if (await userManager.FindByEmailAsync(assistant.Email) == null)
            {
                // Dentist Assistant
                await userStore.SetUserNameAsync(assistant, assistant.Email, CancellationToken.None);
                var result = await userManager.CreateAsync(assistant, "Assistant123!");

                if (result.Succeeded)
                {
                    await userManager.ConfirmEmailAsync(assistant, await userManager.GenerateEmailConfirmationTokenAsync(assistant));
                    await userManager.AddToRoleAsync(assistant, "DentistAssistant");
                }
            }

            if (await userManager.FindByEmailAsync(patient.Email) == null)
            {
                // Patient
                await userStore.SetUserNameAsync(patient, patient.Email, CancellationToken.None);
                var result = await userManager.CreateAsync(patient, "Patient123!");

                if (result.Succeeded)
                {
                    await userManager.ConfirmEmailAsync(patient, await userManager.GenerateEmailConfirmationTokenAsync(patient));
                    await userManager.AddToRoleAsync(patient, "Patient");
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
