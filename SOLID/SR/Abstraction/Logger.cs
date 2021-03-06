﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SR.Abstraction
{
	public class Logger
	{
		public void LogFile(string filePath, string log)
		{
			File.WriteAllText(filePath, log);

		}
		public string BulidLog(string information)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("Date: ");
			sb.Append(DateTime.Now.ToString());
			sb.AppendLine();
			sb.Append("Information:").Append(information);

			return sb.ToString();
		}
	}
}
