using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
	internal delegate void YaLeFeu(Adresse adresse);

	internal class Standard
	{
		private event YaLeFeu? FeuEstDeclare;

		public void Subscribe(YaLeFeu handler)
		{
			this.FeuEstDeclare += handler;
		}

		public void Appeler(Adresse adresse)
		{
			Console.WriteLine(adresse);
			this.FeuEstDeclare?.Invoke(adresse);
		}
	}
}
