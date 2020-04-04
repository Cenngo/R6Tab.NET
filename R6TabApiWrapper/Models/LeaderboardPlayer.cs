using Newtonsoft.Json;
using R6Api.Models;
using R6Api.Models.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6TabApiWrapper.Models
{
	public class LeaderboardPlayer
	{
		[JsonProperty("ranked")]
		public RankedBase Ranked { get; internal set; }
		[JsonProperty("stats")]
		public StatsBase Stats { get; internal set; }
		[JsonProperty("profile")]
		public Profile Profile { get; internal set; }
	}
}
