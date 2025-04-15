using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
	internal class Pompier
	{
		public void AllerEteindre(Adresse adresse)
		{
			Console.WriteLine($"J'éteins le feu ici : ${adresse}");
		}
	}
}
