using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Ade",
                    Email   ="ade@gmail.com",
                    UserName = "ade@gmail.com",
                    Address = new Address 
                    {
                        FirstName = "Adeola",
                        LastName = "Olayinka",
                        Street = "10 Remilekun street ikorodu",
                        City = "Ikorodu",
                        State = "Lagos",
                        ZipCode = "90210"
                    }
                };
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}