using SOLID.DIP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.ConCreat
{
	public class Kebap : IProduct
	{
		public string PisirmeTalimatlari()
		{
			return "Kebap Tarifleri";
		}
	}
}
