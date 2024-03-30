using DAS.Domain.Main.User;
using DAS.Infrastructure.Seeding;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DAS.Infrastructure.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<SysUser> SysUser { get; set; }

        //Seeding the data to the database || adding the default data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);

            SysUserSeeding.Seeding(modelBuilder);

        }
    }
}
