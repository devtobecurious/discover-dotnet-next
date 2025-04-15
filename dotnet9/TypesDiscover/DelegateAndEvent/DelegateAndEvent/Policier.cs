using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
	internal class Policier
	{
		public void ReleverLesInformations(Adresse adresse)
		{
			Console.WriteLine($"A noter pour le dossier, adresse : ${adresse}");
		}
	}
}
