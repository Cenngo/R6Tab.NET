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
		/// <summary>
		/// Ranked Stats of the Player
		/// </summary>
		[JsonProperty("ranked")]
		public RankedBase Ranked { get; internal set; }
		/// <summary>
		/// General Stats of the Player
		/// </summary>
		[JsonProperty("stats")]
		public StatsBase Stats { get; internal set; }
		/// <summary>
		/// Profile of the Player
		/// </summary>
		[JsonProperty("profile")]
		public Profile Profile { get; internal set; }
	}
}
