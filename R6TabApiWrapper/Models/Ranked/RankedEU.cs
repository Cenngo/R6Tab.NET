using Newtonsoft.Json;
using R6Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	/// <summary>
	/// Ranked Data for EU Region for Rainbow6
	/// </summary>
	public class RankedEU : IRegionRanked
	{
		[JsonProperty("EU_kills")]
		public int Kills { get; internal set; }
		[JsonProperty("EU_deaths")]
		public int Deaths { get; internal set; }
		[JsonProperty("EU_wins")]
		public int Wins { get; internal set; }
		[JsonProperty("EU_losses")]
		public int Losses { get; internal set; }
		[JsonProperty("EU_abandons")]
		public int Abandons { get; internal set; }
		[JsonProperty("EU_maxmmr")]
		public int MaxMmr { get; internal set; }
		/// <summary>
		/// Champ Tier of the Player
		/// </summary>
		[JsonProperty("EU_champ")]
		public int Champ { get; internal set; }
		[JsonProperty("EU_mmrchange")]
		public int MmrChange { get; internal set; }
		[JsonProperty("EU_actualmmr")]
		public int ActualMmr { get; internal set; }
		/// <summary>
		/// Number of  Matches Played
		/// </summary>
		[JsonProperty("EU_matches")]
		public int Matches { get; internal set; }
		[JsonProperty("EU_wl")]
		internal string _winLose { get; set; }

		/// <summary>
		/// Win/Lose Ratio as Percentage
		/// </summary>
		[JsonIgnore]
		public double WinLose
		{
			get
			{
				return Convert.ToDouble(_winLose.Remove(_winLose.Length - 1));
			}
		}
		[JsonProperty("EU_kd")]
		internal string _kd { get; set; }
		/// <summary>
		/// Kill/Death Ratio as Percentage
		/// </summary>
		[JsonIgnore]
		public double KillDeath
		{
			get
			{
				return Convert.ToDouble(_kd);
			}
		}
		[JsonProperty("EU_rank")]
		public int Rank { get; internal set; }
		[JsonProperty("EU_rankname")]
		public string RankName { get; internal set; }
		[JsonProperty("EU_maxrank")]
		public int MaxRank { get; internal set; }
		[JsonProperty("EU_maxrankname")]
		public string MaxRankName { get; internal set; }
		[JsonProperty("EU_killpermatch")]
		public double KillPerMatch { get; internal set; }
		[JsonProperty("EU_deathspermatch")]
		public double DeathPerMatch { get; internal set; }
		/// <summary>
		/// Get Rank Banner for the Player's Current Rank
		/// </summary>
		/// <returns>Url of the Banner Img</returns>
		public string GetRankImg ()
		{
			return $"https://cdn.tab.one/r6/images/ranks/?rank={Rank}&champ={Champ}";
		}
	}
}
