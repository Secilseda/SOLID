using SOLID.ISP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.ConCreat
{
	public class Sahin : IUcanKus,IUcamayankus
	{
		public string Uc()
		{
			return "Şahin hem uçar";
		}

		public string Yürü()
		{
			return "Şahin hem Yürür";
		}
	}
}
