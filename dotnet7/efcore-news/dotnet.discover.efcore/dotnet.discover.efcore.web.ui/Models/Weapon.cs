namespace dotnet.discover.efcore.web.ui.Models
{
	public class Weapon
	{
        public int Id { get; set; }
        public string Label { get; set; }

        public int Power { get; set; }

        public List<Wookie> Wookies { get; set; }
    }
}
