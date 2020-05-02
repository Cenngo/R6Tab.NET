using Newtonsoft.Json;
using R6Api.Interfaces;
using System;

namespace R6Api.Models
{
	/// <summary>
	/// Ranked Data for NA Region for Rainbow6
	/// </summary>
	public class RankedNA : IRegionRanked
	{
		/// <inheritdoc/>
		[JsonProperty("NA_kills")]
		public int Kills { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_deaths")]
		public int Deaths { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_wins")]
		public int Wins { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_losses")]
		public int Losses { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_abandons")]
		public int Abandons { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_maxmmr")]
		public int MaxMmr { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_champ")]
		public int Champ { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_mmrchange")]
		public int MmrChange { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_actualmmr")]
		public int ActualMmr { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_matches")]
		public int Matches { get; internal set; }
		[JsonProperty("NA_wl")]
		internal string _winLose { get; set; }

		/// <inheritdoc/>
		[JsonIgnore]
		public double WinLose
		{
			get
			{
				return Convert.ToDouble(_winLose.Remove(_winLose.Length - 1));
			}
		}
		[JsonProperty("NA_kd")]
		internal string _kd { get; set; }

		/// <inheritdoc/>
		[JsonIgnore]
		public double KillDeath
		{
			get
			{
				return Convert.ToDouble(_kd);
			}
		}
		/// <inheritdoc/>
		[JsonProperty("NA_rank")]
		public int Rank { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_rankname")]
		public string RankName { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_maxrank")]
		public int MaxRank { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_maxrankname")]
		public string MaxRankName { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_killpermatch")]
		public double KillPerMatch { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("NA_deathspermatch")]
		public double DeathPerMatch { get; internal set; }
		/// <summary>
		/// Get Rank Banner for the Player's Current Rank
		/// </summary>
		/// <returns>Url of the Banner Img</returns>
		public string GetRankImg()
		{
			return $"https://cdn.tab.one/r6/images/ranks/?rank={Rank}&champ={Champ}";
		}
	}
}
