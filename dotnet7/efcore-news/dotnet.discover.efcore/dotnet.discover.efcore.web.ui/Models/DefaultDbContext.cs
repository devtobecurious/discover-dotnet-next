using dotnet.discover.efcore.web.ui.Models.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace dotnet.discover.efcore.web.ui.Models
{
	public class DefaultDbContext : DbContext
	{
		protected DefaultDbContext()
		{
		}

		public DefaultDbContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new WookieEntityTypeConfiguration());
			modelBuilder.ApplyConfiguration(new WeaponEntityTypeConfiguration());
		}

        public DbSet<Wookie> Wookies { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
    }
}
