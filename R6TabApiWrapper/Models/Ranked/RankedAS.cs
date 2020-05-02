using Newtonsoft.Json;
using R6Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	/// <summary>
	/// Ranked Data for AS Region for Rainbow6
	/// </summary>
	public class RankedAS : IRegionRanked
	{
		/// <inheritdoc/>
		[JsonProperty("AS_kills")]
		public int Kills { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("AS_deaths")]
		public int Deaths { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("_wins")]
		public int Wins { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("AS_losses")]
		public int Losses { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("AS_abandons")]
		public int Abandons { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("AS_maxmmr")]
		public int MaxMmr { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("AS_champ")]
		public int Champ { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("AS_mmrchange")]
		public int MmrChange { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("AS_actualmmr")]
		public int ActualMmr { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("AS_matches")]
		public int Matches { get; internal set; }
		[JsonProperty("AS_wl")]
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
		[JsonProperty("AS_kd")]
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
		[JsonProperty("AS_rank")]
		public int Rank { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("AS_rankname")]
		public string RankName { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("AS_maxrank")]
		public int MaxRank { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("AS_maxrankname")]
		public string MaxRankName { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("AS_killpermatch")]
		public double KillPerMatch { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("AS_deathspermatch")]
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
