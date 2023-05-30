using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_like_classes
{
    internal interface IFly
    {
        void Fly();

        void SpeedFly()
        {
            Console.WriteLine("I fly so wuick !");
        }
    }
}
