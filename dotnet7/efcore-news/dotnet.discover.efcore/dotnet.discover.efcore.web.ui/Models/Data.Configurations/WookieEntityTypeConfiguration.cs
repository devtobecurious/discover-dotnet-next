using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnet.discover.efcore.web.ui.Models.Data.Configurations
{
	public class WookieEntityTypeConfiguration : IEntityTypeConfiguration<Wookie>
	{
		public void Configure(EntityTypeBuilder<Wookie> builder)
		{
			builder.ToTable("Wookie");
		}
	}
}
