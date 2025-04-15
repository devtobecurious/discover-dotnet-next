using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
	internal record Adresse(string Rue, string Ville, string CodePostal)
	{
		public override string ToString()
		{
			return $"{this.Rue}, {this.Ville}, {this.CodePostal}";
		}
	}
}
