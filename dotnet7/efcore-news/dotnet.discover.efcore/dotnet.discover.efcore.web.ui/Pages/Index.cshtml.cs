using dotnet.discover.efcore.web.ui.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace dotnet.discover.efcore.web.ui.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger, DefaultDbContext context)
		{
			_logger = logger;
			this.Context = context;
		}

		public DefaultDbContext Context { get; }

		public async Task OnGet()
		{
			this.Weapons = await this.Context.Weapons.AsNoTracking().ToListAsync();
			this.Wookies = await this.Context.Wookies.AsNoTracking().Include(item => item.Weapons).ToListAsync();
		}

        public List<Weapon> Weapons { get; set; }
		public List<Wookie> Wookies { get; set; }
    }
}