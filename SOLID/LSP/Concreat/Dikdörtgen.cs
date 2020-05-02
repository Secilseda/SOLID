using SOLID.LSP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Concreat
{
	public class Dikdörtgen:Shape
	{
		public int Yükseklik { get; set; }
		public int Genislik { get; set; }
		public double DikdörtgenAlan()
		{
			return Genislik * Yükseklik;
		}
	}
}
