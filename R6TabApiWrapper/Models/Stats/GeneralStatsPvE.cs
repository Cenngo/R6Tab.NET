using Newtonsoft.Json;
using R6Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models.Stats
{
	public class GeneralStatsPvE : IGamemodeStats
	{
		[JsonProperty("generalpve_kills")]
		public int Kills { get; internal set; }
		[JsonProperty("generalpve_death")]
		public int Deaths { get; internal set; }
		[JsonProperty("generalpve_matchwon")]
		public int MatchesWon { get; internal set; }
		[JsonProperty("generalpve_matchlost")]
		public int MatchesLost { get; internal set; }
		[JsonProperty("generalpve_timeplayed")]
		public int TimePlayed { get; internal set; }
		[JsonProperty("generalpve_hoursplayed")]
		public int HoursPlayed { get; internal set; }
		[JsonProperty("generalpve_matches")]
		public int MatchesPlayed { get; internal set; }
		[JsonProperty("generalpve_kd")]
		public string _kd { get; internal set; }
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
		[JsonProperty("generalpve_wl")]
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
		[JsonProperty("generalpve_killassists")]
		public int KillAssists { get; internal set; }
		[JsonProperty("generalpve_meleekills")]
		public int MeleeKills { get; internal set; }
		[JsonProperty("generalpve_revive")]
		public int Revives { get; internal set; }
		[JsonProperty("generalpve_penetrationkills")]
		public int PenetrationKills { get; internal set; }
		[JsonProperty("generalpve_headshot")]
		public int Headshots { get; internal set; }
	}
}
