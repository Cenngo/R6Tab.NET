using Newtonsoft.Json;
using R6Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models.Stats
{
	public class GeneralStatsPvP : IGamemodeStats
	{
		/// <inheritdoc/>
		[JsonProperty("generalpvp_kills")]
		public int Kills { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("generalpvp_death")]
		public int Deaths { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("generalpvp_matchwon")]
		public int MatchesWon { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("generalpvp_matchlost")]
		public int MatchesLost { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("generalpvp_timeplayed")]
		public int TimePlayed { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("generalpvp_hoursplayed")]
		public int HoursPlayed { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("generalpvp_matches")]
		public int MatchesPlayed { get; internal set; }
		[JsonProperty("generalpvp_kd")]
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
		[JsonProperty("generalpvp_wl")]
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
		[JsonProperty("generalpvp_hsrate")]
		internal string _hsRate {get; set;}
		/// <summary>
		/// Headshot Ratio as Percentage
		/// </summary>
		[JsonIgnore]
		public double HeadShotRate { get
			{
				return Convert.ToDouble(_hsRate.Remove(_winLose.Length - 1));
		} }
		/// <summary>
		/// Number of Kill Assists
		/// </summary>
		[JsonProperty("generalpvp_killassists")]
		public int KillAssists { get; internal set; }
		/// <summary>
		/// Number of Melee Kills
		/// </summary>
		[JsonProperty("generalpvp_meleekills")]
		public int MeleeKills { get; internal set; }
		/// <summary>
		/// Number of Revives
		/// </summary>
		[JsonProperty("generalpvp_revive")]
		public int Revives { get; internal set; }
		/// <summary>
		/// Number of Penetration Kills
		/// </summary>
		[JsonProperty("generalpvp_penetrationkills")]
		public int PenetrationKills { get; internal set; }
		/// <summary>
		/// Number of Headshots
		/// </summary>
		[JsonProperty("generalpvp_headshot")]
		public int Headshots { get; internal set; }
	}
}
