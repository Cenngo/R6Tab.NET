using Newtonsoft.Json;
using R6Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models.Stats
{
	public class CasualStats : IGamemodeStats
	{
		/// <inheritdoc/>
		[JsonProperty("casualpvp_kills")]
		public int Kills { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("casualpvp_death")]
		public int Deaths { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("casualpvp_matchwon")]
		public int MatchesWon { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("casualpvp_matchlost")]
		public int MatchesLost { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("casualpvp_timeplayed")]
		public int TimePlayed { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("casualpvp_hoursplayed")]
		public int HoursPlayed { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("casualpvp_matches")]
		public int MatchesPlayed { get; internal set; }
		[JsonProperty("casualpvp_kd")]
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
		[JsonProperty("casualpvp_wl")]
		internal string _winLose { get; set; }
		/// <inheritdoc/>
		[JsonIgnore]
		public double WinLose { get
			{
				return Convert.ToDouble(_winLose.Remove(_winLose.Length - 1));
			} }
	}
}
