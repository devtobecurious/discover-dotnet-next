namespace dotnet.discover.efcore.web.ui.Models
{
	public class Wookie
	{
        public int Id { get; set; }
        public string Surname { get; set; }

        public ICollection<Weapon> Weapons { get; set; }
        public ICollection<LightSaber> LightSabers { get; set; }
    }
}
