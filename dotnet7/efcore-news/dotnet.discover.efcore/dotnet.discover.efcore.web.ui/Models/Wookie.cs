namespace dotnet.discover.efcore.web.ui.Models
{
	public class Wookie : Person
	{
        public ICollection<Weapon> Weapons { get; set; }
    }
}
