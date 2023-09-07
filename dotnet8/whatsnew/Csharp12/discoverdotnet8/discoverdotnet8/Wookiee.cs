namespace discoverdotnet8
{
    internal interface ILoader { }

    internal class Wookiee(int id, string name)
    {
        public string Name { get; set; } = name;
    }

    internal class ChildWookie(int id, string name, int power) : Wookiee(id, name)
    {
        public ChildWookie(int shield) : this(1, "", 10)
        {

        }
    }
}
