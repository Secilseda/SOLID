using SOLID.LSP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Concreat
{
	public class Kare:Shape
	{
		public int Genislik { get; set; }
		public double KareAlan()
		{
			return Genislik * Genislik;
		}
	}
}
