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
	public class DataByName : SearchResult
	{
		[JsonProperty("foundmatch")]
		public bool FoundMatch { get; internal set; }
		[JsonProperty("requested")]
		public string RequestedName { get; internal set; }
		/// <summary>
		/// Found Matches for the Searched Name
		/// </summary>
		public IDictionary<string, Player> FoundPlayers { get; internal set; }
	}
}
