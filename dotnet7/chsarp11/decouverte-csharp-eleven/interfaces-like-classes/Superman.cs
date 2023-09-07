using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_like_classes
{
    internal class Superman : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I fly");
        }

    }
}
