namespace R6Api
{
	public class R6Config
	{
		public R6Config ()
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
		/// <summary>
		/// Api Key from Tabwire. Contact https://tabstats.com/contact for a key.
		/// </summary>
		public string ApiKey = null;
	}
}
