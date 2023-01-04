namespace ConnectWithEfCore.Models.Data
{
    public class Wizard
    {
        public int Id { get; set; }

        public ICollection<Wand> Wands { get; set; }
    }
}
