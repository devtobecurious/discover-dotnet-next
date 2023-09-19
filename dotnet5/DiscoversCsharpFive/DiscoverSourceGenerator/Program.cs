using DiscoverSourceGenerator;

namespace ConsoleApp
{
    public static partial class Program
    {
        static void Main(string[] args)
        {
            Wookiee wookiee = new();

            wookiee.Crier();
        }
    }
}