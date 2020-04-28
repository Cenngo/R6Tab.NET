using Newtonsoft.Json;
using R6Api.Interfaces;
using R6Api.Models.SearchResults;
using R6TabApiWrapper.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6TabApiWrapper.Models.SearchResults
{
	public class LeaderboardData : SearchResult
	{
		[JsonProperty("region")]
		internal string _region { get; set; }
		/// <summary>
		/// Region of the Leaderboard
		/// </summary>
		[JsonIgnore]
		public Region Region { get
			{
				return (Region)Enum.Parse(typeof(Region), _region);
		} }
		[JsonProperty("platform")]
		public string Platform { get; internal set; }
		[JsonProperty("regtext")]
		public string RegionText { get; internal set; }
		[JsonProperty("plattext")]
		public string PlatformText { get; internal set; }
		[JsonProperty("players")]
		public IDictionary<string, LeaderboardPlayer> LeaderBoard { get; internal set; }
	}
}
