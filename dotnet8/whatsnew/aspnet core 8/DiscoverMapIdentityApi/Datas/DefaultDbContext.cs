using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DiscoverMapIdentityApi;

public class DefaultDbContext : IdentityDbContext
{
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
    {
    }

    protected DefaultDbContext()
    {
    }
}
