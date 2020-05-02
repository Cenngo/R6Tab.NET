using Newtonsoft.Json;
using R6Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models.Stats
{
	public class RankedStats : IGamemodeStats
	{
		/// <inheritdoc/>
		[JsonProperty("rankedpvp_kills")]
		public int Kills { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("rankedpvp_death")]
		public int Deaths { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("rankedpvp_matchwon")]
		public int MatchesWon { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("rankedpvp_matchlost")]
		public int MatchesLost { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("rankedpvp_timeplayed")]
		public int TimePlayed { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("rankedpvp_hoursplayed")]
		public int HoursPlayed { get; internal set; }
		/// <inheritdoc/>
		[JsonProperty("rankedpvp_matches")]
		public int MatchesPlayed { get; internal set; }
		[JsonProperty("rankedpvp_kd")]
		internal string _kd { get; set; }
		/// <inheritdoc/>
		[JsonIgnore]
		public double KillDeath { get
			{
				return Convert.ToDouble(_kd);
			} }
		[JsonProperty("rankedpvp_wl")]
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
	}
}
