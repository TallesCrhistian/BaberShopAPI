using BaberShopAPI.Entities;
using BaberShopAPI.Shared.Enumerators;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace BaberShopAPI.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<EnumGender>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            modelBuilder.HasPostgresEnum<EnumGender>();
        }

        public DbSet<Client> Customers { get; set; }
    }
}
