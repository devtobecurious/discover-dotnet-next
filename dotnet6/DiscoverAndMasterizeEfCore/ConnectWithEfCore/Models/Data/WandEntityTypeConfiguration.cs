using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConnectWithEfCore.Models.Data
{
    public class WandEntityTypeConfiguration : IEntityTypeConfiguration<Wand>
    {
        public void Configure(EntityTypeBuilder<Wand> builder)
        {
            builder.ToTable("Wand");
        }
    }
}
