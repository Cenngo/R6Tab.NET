using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	public class SeasonRanked
	{
		[JsonProperty("NA_mmr")]
		public int NaMmr { get; internal set; }
		[JsonProperty("NA_champ")]
		public int? NaChamp { get; internal set; }
		[JsonProperty("NA_wins")]
		public int? NaWins { get; internal set; }
		[JsonProperty("NA_losses")]
		public int? NaLosses { get; internal set; }
		[JsonProperty("NA_abandons")]
		public int? NaAbandons { get; internal set; }
		[JsonProperty("NA_kills")]
		public int? NaKills { get; internal set; }
		[JsonProperty("NA_deaths")]
		public int? NaDeaths { get; internal set; }

		[JsonProperty("EU_mmr")]
		public int EuMmr { get; internal set; }
		[JsonProperty("EU_champ")]
		public int? EuChamp { get; internal set; }
		[JsonProperty("EU_wins")]
		public int? EuWins { get; internal set; }
		[JsonProperty("EU_losses")]
		public int? EuLosses { get; internal set; }
		[JsonProperty("EU_abandons")]
		public int? EuAbandons { get; internal set; }
		[JsonProperty("EU_kills")]
		public int? EuKills { get; internal set; }
		[JsonProperty("EU_deaths")]
		public int? EuDeaths { get; internal set; }

		[JsonProperty("AS_mmr")]
		public int AsMmr { get; internal set; }
		[JsonProperty("AS_champ")]
		public int? AsChamp { get; internal set; }
		[JsonProperty("AS_wins")]
		public int? AsWins { get; internal set; }
		[JsonProperty("AS_losses")]
		public int? AsLosses { get; internal set; }
		[JsonProperty("AS_abandons")]
		public int? AsAbandons { get; internal set; }
		[JsonProperty("AS_kills")]
		public int? AsKills { get; internal set; }
		[JsonProperty("AS_deaths")]
		public int? AsDeaths { get; internal set; }

		[JsonProperty("seasonname")]
		public string SeasonName { get; internal set; }
		[JsonProperty("seasonclass")]
		public string SeasonClass { get; internal set; }
		[JsonProperty("champ")]
		public string Champ { get; internal set; }
		[JsonProperty("maxmmr")]
		public int? MaxMmr { get; internal set; }
		[JsonProperty("maxrank")]
		public int MaxRank { get; internal set; }
		[JsonProperty("maxrankname")]
		public string MaxRankName { get; internal set; }
		public string GetMaxRankImg()
		{
			if (MaxMmr == 0)
				return null;
			else
				return $"https://cdn.tab.one/r6/images/ranks/?rank={MaxRank}&champ={Champ}";
		}
	}
}
