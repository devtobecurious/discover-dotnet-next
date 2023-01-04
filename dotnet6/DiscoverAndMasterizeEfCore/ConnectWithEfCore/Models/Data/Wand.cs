namespace ConnectWithEfCore.Models.Data
{
    public class Wand
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Wizard> Wizards { get; set; }
    }
}
