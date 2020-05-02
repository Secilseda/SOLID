using SOLID.OCP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.ConCreat
{
	public class Latte : Kahve
	{
		public override double ToplamFiyat(double tutar)
		{
			return tutar * 4.50;
		}
	}
}
