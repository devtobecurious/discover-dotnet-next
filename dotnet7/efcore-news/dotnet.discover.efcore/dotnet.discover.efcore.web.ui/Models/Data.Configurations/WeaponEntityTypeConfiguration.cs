using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace dotnet.discover.efcore.web.ui.Models.Data.Configurations
{
	public class WeaponEntityTypeConfiguration : IEntityTypeConfiguration<Weapon>
	{
		public void Configure(EntityTypeBuilder<Weapon> builder)
		{
			builder.ToTable("Weapons");
		}
	}
}
