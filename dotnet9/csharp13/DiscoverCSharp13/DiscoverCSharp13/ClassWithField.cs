using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverCSharp13
{
	class ClassWithField
	{
		public int Age
		{
			get;
			set => value = field > 13 ? value : throw new ArgumentOutOfRangeException("Age requis");
		}
	}
}
