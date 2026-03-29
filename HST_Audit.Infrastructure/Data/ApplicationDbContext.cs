using Microsoft.EntityFrameworkCore;
using HST_Audit.Domain.Entities;

namespace HST_Audit.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}