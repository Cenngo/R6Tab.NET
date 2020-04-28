using Newtonsoft.Json;
using R6Api.Interfaces;
using R6Api.Models.Bases;
using R6Api.Models.Ranked;
using R6Api.Models.Stats;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace R6Api.Models.SearchResults
{
	/// <summary>
	/// Api Data, Parsed from Id Search for Rainbow6
	/// </summary>
	public class DataById : SearchResult
	{
		[JsonProperty("found")]
		public bool MatchFound { get; internal set; }
		/// <summary>
		/// Credentials of the Player
		/// </summary>
		[JsonProperty("player")]
		public PlayerBase Player { get; internal set; }
		[JsonProperty("custom")]
		public Custom Customs { get; internal set; }
		[JsonProperty("refresh")]
		public RefreshDetailed Refresh {get; internal set;}
		[JsonIgnore]
		public IEnumerable<Alias> Aliases { get; internal set; }
		/// <summary>
		/// Overall Stats of the Player
		/// </summary>
		[JsonProperty("stats")]
		public StatsFromId Stats { get; internal set; }
		/// <summary>
		/// Ranked Stats of the Player
		/// </summary>
		[JsonProperty("ranked")]
		public RankedFromId Ranked { get; internal set; }
		/// <summary>
		/// Social Network Information as Registered to R6Tab.
		/// </summary>
		[JsonIgnore]
		public Social Social { get; internal set; }
		/// <summary>
		/// Seasonal Ranked Data
		/// </summary>
		[JsonProperty("seasons")]
		public IDictionary<int, SeasonRanked> Seasons { get; internal set; }
		/// <summary>
		/// Operator Datas
		/// </summary>
		[JsonIgnore]
		public Operators Operators { get; internal set; }
	}
}
