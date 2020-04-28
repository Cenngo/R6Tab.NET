using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models.Stats
{
	public class StatsFromId : StatsBase
	{
		/// <summary>
		/// Casual Gamemode Stats of the  Player
		/// </summary>
		[JsonIgnore]
		public CasualStats Casual { get; internal set; }
		/// <summary>
		/// Ranked Gamemode Stats of the  Player
		/// </summary>
		[JsonIgnore]
		public RankedStats Ranked { get; internal set; }
		/// <summary>
		/// GeneralPvP Gamemode Stats of the  Player
		/// </summary>
		[JsonIgnore]
		public GeneralStatsPvP GeneralPvP { get; internal set; }
		/// <summary>
		/// GeneralPvE Gamemode Stats of the  Player
		/// </summary>
		[JsonIgnore]
		public GeneralStatsPvE GeneralPvE { get; internal set; }
		/// <summary>
		/// Plant Bomb Game Mode Wins
		/// </summary>
		[JsonProperty("plantbombpvp_matchwon")]
		public int PlantBombMatchesWon { get; internal set; }
		/// <summary>
		/// Plant Bomb Game Mode Losses
		/// </summary>
		[JsonProperty("plantbombpvp_matchlost")]
		public int PlantBombMathcesLost { get; internal set; }
		/// <summary>
		/// Secure Area Game Mode Wins
		/// </summary>
		[JsonProperty("secureareapvp_matchwon")]
		public int SecureAreaMatchesWon { get; internal set; }
		/// <summary>
		/// Secure Area Game Mode Losses
		/// </summary>
		[JsonProperty("secureareapvp_matchlost")]
		public int SecureAreaMatchesLost { get; internal set; }
		/// <summary>
		/// Rescue Hostage Game Mode Wins
		/// </summary>
		[JsonProperty("rescuehostagepvp_matchwon")]
		public int RescueHostageMatchesWon { get; internal set; }
		/// <summary>
		/// Rescue Hostage Game Mode Losses
		/// </summary>
		[JsonProperty("rescuehostagepvp_matchlost")]
		public int RescueHostageMatchesLost { get; internal set; }
		/// <summary>
		/// Count of Matches Played in Plant Bomb Game Mode
		/// </summary>
		[JsonProperty("plantbombpvp_matches")]
		public int PlantBombMatches { get; internal set; }
		[JsonProperty("plantbombpvp_wl")]
		internal string _plantBombWl { get; set; }
		/// <summary>
		/// Win/Lose Rate of Matches Played in Plant Bomb Game Mode
		/// </summary>
		[JsonIgnore]
		public double PlantBombMatchesWl {
			get { return Convert.ToDouble(_plantBombWl.Remove(_plantBombWl.Length - 1)); } }
		/// <summary>
		/// Count of Matches Played in Secure Area Game Mode
		/// </summary>
		[JsonProperty("secureareapvp_matches")]
		public int SecureAreaMatches { get; internal set; }
		[JsonProperty("secureareapvp_wl")]
		internal string _secureAreaWl { get; set; }
		/// <summary>
		/// Win/Lose Rate of Matches Played in Secure Area Game Mode
		/// </summary>
		[JsonIgnore]
		public double SecureAreaMatchesWl
		{
			get { return Convert.ToDouble(_secureAreaWl.Remove(_secureAreaWl.Length - 1)); }
		}
		/// <summary>
		/// Count of Matches Played in Rescue Hostage Game Mode
		/// </summary>
		[JsonProperty("rescuehostagepvp_matches")]
		public int RescueHostageMatches { get; internal set; }		
		[JsonProperty("rescuehostagepvp_wl")]
		internal string _rescueHostageWl { get; set; }
		/// <summary>
		/// Win/Lose Rate of Matches Played in Rescue Hostage Game Mode
		/// </summary>
		[JsonIgnore]
		public double RescueHostageMatchesWl
		{
			get { return Convert.ToDouble(_rescueHostageWl.Remove(_rescueHostageWl.Length - 1)); }
		}
		/// <summary>
		/// R6Tab MMR of the User 
		/// </summary>
		[JsonProperty("tabmmr")]
		public int TabMmr { get; internal set; }
		/// <summary>
		/// R6Tab Rank of The User
		/// </summary>
		[JsonProperty("tabrank")]
		public int TabRank { get; internal set; }
		/// <summary>
		/// Rank Name of User's R6Tab Rank
		/// </summary>
		[JsonProperty("tabrankname")]
		public string TabRankName { get; internal set; }
	}
}
