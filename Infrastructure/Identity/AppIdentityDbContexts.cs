using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Core.Entities.Identity;



namespace Infrastructure.Identity
{
    public class AppIdentityDbContexts : IdentityDbContext<AppUser>
    {
        public AppIdentityDbContexts(DbContextOptions<AppIdentityDbContexts> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}