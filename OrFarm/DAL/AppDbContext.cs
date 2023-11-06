using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrFarm.Models.Account;
using System.Reflection.Metadata;

namespace OrFarm.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser, UserRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}

