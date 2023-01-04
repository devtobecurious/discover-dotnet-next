using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConnectWithEfCore.Models.Data
{
    public class WizardEntityTypeConfiguration : IEntityTypeConfiguration<Wizard>
    {
        public void Configure(EntityTypeBuilder<Wizard> builder)
        {
            builder.ToTable("Wizard");
        }
    }
}
