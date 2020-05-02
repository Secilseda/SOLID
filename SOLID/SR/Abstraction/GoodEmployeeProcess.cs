using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SR.Abstraction
{
	public class GoodEmployeeProcess
	{
		Logger logger;
		string log;
		public GoodEmployeeProcess()
		{
			logger = new Logger();
		}
		public bool InsertEmployee(Employee employee)//Farklı bir namespace altında olan sınıfttan instance alınıyor
		{
			StringBuilder sb = new StringBuilder();
			try
			{
				sb.Append(employee.Id);
				sb.AppendLine();
				sb.Append(employee.FirstName);
				sb.AppendLine();
				sb.Append(employee.LastName);

				log = logger.BulidLog(sb.ToString());
				logger.LogFile(@"C:\YMS5173Log.txt", log);

				log = logger.BulidLog("Employee Insert Successfull:" + employee.Id);
				logger.LogFile(@"C:\YMS5173Log.txt", log);

				return true;


			}
			catch (Exception ex)
			{
				log = logger.BulidLog("Hata Mesajı:" + ex.Message);
				logger.LogFile(@"C:\YMS5173Log.txt", log);

				return false;

			}
		}
	}
}
