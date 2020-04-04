using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	public class OperatorData
	{
		/// <summary>
		/// Operator Data as Sorted for Wins
		/// </summary>
		[JsonProperty("wins")]
		public IDictionary<string, int>  Wins { get; internal set; }
		/// <summary>
		/// Operator Data as Sorted for Losses
		/// </summary>
		[JsonProperty("losses")]
		public IDictionary<string, int> Losses { get; internal set; }
		/// <summary>
		/// Operator Data as Sorted for Kills
		/// </summary>
		[JsonProperty("kills")]
		public IDictionary<string, int> Kills { get; internal set; }
		/// <summary>
		/// Operator Data as Sorted for Deaths
		/// </summary>
		[JsonProperty("deaths")]
		public IDictionary<string, int> Deaths { get; internal set; }
		/// <summary>
		/// Operator Data as Sorted for Time Played
		/// </summary>
		[JsonProperty("timeplayed")]
		public IDictionary<string, int> TimePLayed { get; internal set; }
	}
}
