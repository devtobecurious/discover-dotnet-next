using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_like_classes
{
    internal interface IPlane : IFly
    {
        abstract void IFly.SpeedFly();
    }
}
