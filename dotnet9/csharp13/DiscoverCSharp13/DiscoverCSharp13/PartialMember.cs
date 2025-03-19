using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverCSharp13
{
	partial class PartialMember
	{
		public partial string Name { get; set; }
	}

	partial class PartialMember
	{
		string _name;
		public partial string Name
		{
			get => this._name;
			set => this._name = value;
		}
	}
}
