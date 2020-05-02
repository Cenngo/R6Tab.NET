using Newtonsoft.Json;
using R6TabApiWrapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	public class SeasonRanked
	{
		/// <summary>
		/// Mmr in North America Region
		/// </summary>
		[JsonProperty("NA_mmr")]
		public int NaMmr { get; internal set; }
		/// <summary>
		/// Champ Rank in North America Region
		/// </summary>
		[JsonProperty("NA_champ")]
		public int? NaChamp { get; internal set; }
		/// <summary>
		/// Wins in North America Region
		/// </summary>
		[JsonProperty("NA_wins")]
		public int? NaWins { get; internal set; }
		/// <summary>
		/// Losses in North America Region
		/// </summary>
		[JsonProperty("NA_losses")]
		public int? NaLosses { get; internal set; }
		/// <summary>
		/// Abandons in North America Region
		/// </summary>
		[JsonProperty("NA_abandons")]
		public int? NaAbandons { get; internal set; }
		/// <summary>
		/// Kills in North America Region
		/// </summary>
		[JsonProperty("NA_kills")]
		public int? NaKills { get; internal set; }
		/// <summary>
		/// Deaths in North America Region
		/// </summary>
		[JsonProperty("NA_deaths")]
		public int? NaDeaths { get; internal set; }
		/// <summary>
		/// Mmr in North America Region
		/// </summary>
		[JsonProperty("EU_mmr")]
		public int EuMmr { get; internal set; }
		/// <summary>
		/// Champ Rank in North America Region
		/// </summary>
		[JsonProperty("EU_champ")]
		public int? EuChamp { get; internal set; }
		/// <summary>
		/// Wins in North America Region
		/// </summary>
		[JsonProperty("EU_wins")]
		public int? EuWins { get; internal set; }
		/// <summary>
		/// Losses in North America Region
		/// </summary>
		[JsonProperty("EU_losses")]
		public int? EuLosses { get; internal set; }
		/// <summary>
		/// Abandons in North America Region
		/// </summary>
		[JsonProperty("EU_abandons")]
		public int? EuAbandons { get; internal set; }
		/// <summary>
		/// Kills in North America Region
		/// </summary>
		[JsonProperty("EU_kills")]
		public int? EuKills { get; internal set; }
		/// <summary>
		/// Deaths in North America Region
		/// </summary>
		[JsonProperty("EU_deaths")]
		public int? EuDeaths { get; internal set; }
		/// <summary>
		/// Mmr in Asia Region
		/// </summary>
		[JsonProperty("AS_mmr")]
		public int AsMmr { get; internal set; }
		/// <summary>
		/// Champ Rank in Asia Region
		/// </summary>
		[JsonProperty("AS_champ")]
		public int? AsChamp { get; internal set; }
		/// <summary>
		/// Wins in Asia Region
		/// </summary>
		[JsonProperty("AS_wins")]
		public int? AsWins { get; internal set; }
		/// <summary>
		/// Losses in Asia Region
		/// </summary>
		[JsonProperty("AS_losses")]
		public int? AsLosses { get; internal set; }
		/// <summary>
		/// Abandons in Asia Region
		/// </summary>
		[JsonProperty("AS_abandons")]
		public int? AsAbandons { get; internal set; }
		/// <summary>
		/// Kills in Asia Region
		/// </summary>
		[JsonProperty("AS_kills")]
		public int? AsKills { get; internal set; }
		/// <summary>
		/// deaths in Asia Region
		/// </summary>
		[JsonProperty("AS_deaths")]
		public int? AsDeaths { get; internal set; }

		/// <summary>
		/// Name of the Season
		/// </summary>
		[JsonProperty("seasonname")]
		public string SeasonName { get; internal set; }
		[JsonProperty("seasonclass")]
		public string SeasonClass { get; internal set; }
		/// <summary>
		/// Champ Rank Achieved in the Season
		/// </summary>
		[JsonProperty("champ")]
		public string Champ { get; internal set; }
		/// <summary>
		/// Max Mmr Achieved in the Season
		/// </summary>
		[JsonProperty("maxmmr")]
		public int? MaxMmr { get; internal set; }
		/// <summary>
		/// Max Rank Achieved in the Season
		/// </summary>
		[JsonProperty("maxrank")]
		public int MaxRank { get; internal set; }
		/// <summary>
		/// Name of the Max Rank Achieved in the Season
		/// </summary>
		[JsonProperty("maxrankname")]
		public string MaxRankName { get; internal set; }
		/// <summary>
		/// Get Image Url of the Max Rank Banner
		/// </summary>
		/// <returns>Url of the Banner</returns>
		public string GetMaxRankImg()
		{
			if (MaxMmr == 0)
				return null;
			else
				return $"https://cdn.tab.one/r6/images/ranks/?rank={MaxRank}&champ={Champ}";
		}
	}
}
