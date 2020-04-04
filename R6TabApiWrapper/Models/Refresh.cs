using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	public class Refresh
	{
		[JsonProperty("x")]
		internal int _lastUpdate { get; set; }
		public DateTimeOffset LastUpdated
		{
			get
			{
				return DateTimeOffset.FromUnixTimeSeconds(_lastUpdate);
			}
		}
		[JsonProperty("s")]
		internal int _lastEdit { get; set; }
		public DateTimeOffset LastEdited
		{
			get
			{
				return DateTimeOffset.FromUnixTimeSeconds(_lastEdit);
			}
		}
	}
}
