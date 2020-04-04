using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models.Stats
{
	public class StatsBase
	{
		/// <summary>
		/// Level of the Player
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; internal set; }
	}
}
