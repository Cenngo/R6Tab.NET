using Newtonsoft.Json;
using R6Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models.Stats
{
	public class GeneralStatsPvE : IGamemodeStats
	{
		/// <inheritdoc/>
		[JsonProperty("generalpve_kills")]
		public int Kills { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("generalpve_death")]
		public int Deaths { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("generalpve_matchwon")]
		public int MatchesWon { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("generalpve_matchlost")]
		public int MatchesLost { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("generalpve_timeplayed")]
		public int TimePlayed { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("generalpve_hoursplayed")]
		public int HoursPlayed { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("generalpve_matches")]
		public int MatchesPlayed { get; internal set; }
		[JsonProperty("generalpve_kd")]
		private string _kd { get; set; }
		/// <inheritdoc/>>
		[JsonIgnore]
		public double KillDeath
		{
			get
			{
				return Convert.ToDouble(_kd);
			}
		}
		[JsonProperty("generalpve_wl")]
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
		[JsonProperty("generalpve_hsrate")]
		internal string _hsRate { get; set; }
		/// <summary>
		/// Headshot Ratio as Percentage
		/// </summary>
		[JsonIgnore]
		public double HeadShotRate
		{
			get
			{
				return Convert.ToDouble(_hsRate.Remove(_winLose.Length - 1));
			}
		}
		/// <summary>
		/// Number of Kill Assists
		/// </summary>
		[JsonProperty("generalpve_killassists")]
		public int KillAssists { get; internal set; }
		/// <summary>
		/// Number of Melee Kills
		/// </summary>
		[JsonProperty("generalpve_meleekills")]
		public int MeleeKills { get; internal set; }
		/// <summary>
		/// Number of Revives
		/// </summary>
		[JsonProperty("generalpve_revive")]
		public int Revives { get; internal set; }
		/// <summary>
		/// Number of Penetration Kills
		/// </summary>
		[JsonProperty("generalpve_penetrationkills")]
		public int PenetrationKills { get; internal set; }
		/// <summary>
		/// Number of Headshots
		/// </summary>
		[JsonProperty("generalpve_headshot")]
		public int Headshots { get; internal set; }
	}
}
