using DetectionPersonForShop.DAL.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectionPersonForShop.DAL
{
    public class EFDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options) { }
            
    }


    /// <summary>
    /// For Migrations
    /// </summary>
    public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDBContext>
    {
        public EFDBContext CreateDbContext(string[] arg)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DPS;Username=postgres;Password=root",b=>b.MigrationsAssembly("DetectionPersonForShop.DAL"));

            return new EFDBContext(optionsBuilder.Options);
        }
    }
}
