using Newtonsoft.Json;
using R6Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models.SearchResults
{
	/// <summary>
	/// Api Data, Parsed from Name Search for Rainbow6
	/// </summary>
	public class DataByName : ISearchResult
	{
		/// <summary>
		/// Http Status Code
		/// </summary>
		[JsonProperty("status")]
		public int Status { get; internal set; }
		[JsonProperty("foundmatch")]
		public bool FoundMatch { get; internal set; }
		[JsonProperty("requested")]
		public string RequestedName { get; internal set; }
		/// <summary>
		/// Found Matches for the Searched Name
		/// </summary>
		[JsonProperty("players")]
		public IDictionary<string, Player> FoundPlayers { get; internal set; }
	}
}
