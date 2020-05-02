using SOLID.DIP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.ConCreat
{
	public class Restaurant
	{
		List<IProduct> products;
		public Restaurant()
		{
			products = new List<IProduct>();
		}
		public string TalimatlariOlustur()
		{
			string talimat = string.Empty;
			foreach (var item in products)
			{
				talimat += " " + item.PisirmeTalimatlari();
			}
			return talimat;
		}
	}
}
