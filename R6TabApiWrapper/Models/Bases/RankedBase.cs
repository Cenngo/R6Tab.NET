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
		/// <summary>
		/// Kill/Death Ratio of Player
		/// </summary>
		public double KillDeath
		{
			get
			{
				return Convert.ToDouble(_kd);
			}
		}
		/// <summary>
		/// Current Mmr of Player
		/// </summary>
		[JsonProperty("mmr")]
		public int? Mmr { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("rank")]
		public int Rank { get; internal set; }
		/// <summary>
		/// Champ Rank of the Player
		/// </summary>
		[JsonProperty("champ")]
		public int Champ { get; internal set; }
		/// <summary>
		/// Player Mmr in North America Region
		/// </summary>
		[JsonProperty("NA_mmr")]
		public int NaMmr { get; internal set; }
		/// <summary>
		/// Player Rank in North America Region
		/// </summary>
		[JsonProperty("NA_rank")]
		public int NaRank { get; internal set; }
		/// <summary>
		/// Player Champ Rank in North America Region
		/// </summary>
		[JsonProperty("NA_champ")]
		public int NaChamp { get; internal set; }
		/// <summary>
		/// Player Mmr in Europe Region
		/// </summary>
		[JsonProperty("EU_mmr")]
		public int EuMmr { get; internal set; }
		/// <summary>
		/// Player Rank in Europe Region
		/// </summary>
		[JsonProperty("EU_rank")]
		public int EuRank { get; internal set; }
		/// <summary>
		/// Player Champ Rank in Europe Region
		/// </summary>
		[JsonProperty("EU_champ")]
		public int EuChamp { get; internal set; }
		/// <summary>
		/// Player Mmr in Asia Region
		/// </summary>
		[JsonProperty("AS_mmr")]
		public int AsMmr { get; internal set; }
		/// <summary>
		/// Player Rank in Asia Region
		/// </summary>
		[JsonProperty("AS_rank")]
		public int AsRank { get; internal set; }
		/// <summary>
		/// Player Champ Rank in Asia Region
		/// </summary>
		[JsonProperty("AS_champ")]
		public int AsChamp { get; internal set; }
		/// <inheritdoc/>
		public string GetRankImg ()
		{
			return $"https://cdn.tab.one/r6/images/ranks/?rank={Rank}&champ={Champ}";
		}
	}
}
