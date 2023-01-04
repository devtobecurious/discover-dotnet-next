using Microsoft.EntityFrameworkCore;

namespace ConnectWithEfCore.Models.Data
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions options) : base(options)
        {
        }

        protected DefaultDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WandEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WizardEntityTypeConfiguration());
        }

        public DbSet<Wizard> Wizards { get; set; }
    }
}
