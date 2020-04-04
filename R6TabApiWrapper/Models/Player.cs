using Newtonsoft.Json;
using R6Api.Models.Bases;
using R6Api.Models.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	public class Player
	{
		[JsonProperty("profile")]
		public Profile Profile { get; internal set; }
		[JsonProperty("refresh")]
		public Refresh Refresh { get; internal set; }
		[JsonProperty("stats")]
		public StatsBase Stats { get; internal set; }
		[JsonProperty("ranked")]
		public RankedBase Ranked { get; internal set; }
	}
}
