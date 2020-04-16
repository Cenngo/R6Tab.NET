using Newtonsoft.Json;
using R6TabApiWrapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace R6Api.Models
{
	public class RankedBase : IRankedData
	{
		[JsonProperty("kd")]
		internal string _kd { get; set; }
		public double KillDeath
		{
			get
			{
				return Convert.ToDouble(_kd);
			}
		}
		[JsonProperty("mmr")]
		public int? Mmr { get; internal set; }
		[JsonProperty("rank")]
		public int Rank { get; internal set; }
		[JsonProperty("champ")]
		public int Champ { get; internal set; }
		[JsonProperty("NA_mmr")]
		public int NaMmr { get; internal set; }
		[JsonProperty("NA_rank")]
		public int NaRank { get; internal set; }
		[JsonProperty("NA_champ")]
		public int NaChamp { get; internal set; }
		[JsonProperty("EU_mmr")]
		public int EuMmr { get; internal set; }
		[JsonProperty("EU_rank")]
		public int EuRank { get; internal set; }
		[JsonProperty("EU_champ")]
		public int EuChamp { get; internal set; }
		[JsonProperty("AS_mmr")]
		public int AsMmr { get; internal set; }
		[JsonProperty("AS_rank")]
		public int AsRank { get; internal set; }
		[JsonProperty("AS_champ")]
		public int AsChamp { get; internal set; }
		public string GetRankImg ()
		{
			return $"https://cdn.tab.one/r6/images/ranks/?rank={Rank}&champ={Champ}";
		}
	}
}
