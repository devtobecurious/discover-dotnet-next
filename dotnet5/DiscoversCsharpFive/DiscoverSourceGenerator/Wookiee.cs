using MyAttributes;

namespace DiscoverSourceGenerator
{
    [ToGenerateMore]
    public partial class Wookiee
    {
        public void Crier()
        {
            this.Hurler();
        }

        partial void Hurler();
    }

}
