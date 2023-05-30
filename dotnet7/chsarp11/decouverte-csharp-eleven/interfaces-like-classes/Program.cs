using System;

namespace interfaces_like_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFly fd = new Superman();
            fd.SpeedFly();
            fd.Fly();
        }
    }
}
