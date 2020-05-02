using SOLID.ISP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.ConCreat
{
	public class Tavuk : IUcamayankus
	{
		public string Yürü()
		{
			return "tavuk yürür";
		}
	}
}
