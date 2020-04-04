using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api
{
	public class R6Config
	{
		public R6Config()
		{
		}

		/// <summary>
		/// Auto Send Current Unix Epoch to Avoid Caching
		/// </summary>
		public bool AutoCacheAvoidance = false;
		/// <summary>
		/// Base Url of the Api(defaulted as: https://r6.apitab.com/)
		/// </summary>
		public string BaseUrl = " https://r6.apitab.com/";
	}
}
