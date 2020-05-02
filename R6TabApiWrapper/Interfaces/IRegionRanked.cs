using R6TabApiWrapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace R6Api.Interfaces
{
	/// <summary>
	/// Regional Ranked Data Template for Rainbow6
	/// </summary>
	public interface IRegionRanked : IRankedData
	{
		/// <summary>
		/// Number of Ranked Kills
		/// </summary>
		int Kills { get; }
		/// <summary>
		/// Number of Ranked Deaths
		/// </summary>
		int Deaths { get; }
		/// <summary>
		/// Number of Ranked Match Wins
		/// </summary>
		int Wins { get; }
		/// <summary>
		/// Number of Ranked Match Losses
		/// </summary>
		int Losses { get; }
		/// <summary>
		/// Total Match Abandon Count
		/// </summary>
		int Abandons { get; }
		/// <summary>
		/// Max Mmr Reached
		/// </summary>
		int MaxMmr { get; }
		/// <summary>
		/// Champ Rank of Player
		/// </summary>
		int Champ { get; }
		/// <summary>
		/// Last Mmr Change of the Player
		/// </summary>
		int MmrChange { get; }
		/// <summary>
		/// Actual Mmr of Player
		/// </summary>
		int ActualMmr { get; }
		/// <summary>
		/// Number of Matches Played
		/// </summary>
		int Matches { get; }
		/// <summary>
		/// Win/Lose Rate of Player
		/// </summary>
		double WinLose { get; }
		/// <summary>
		/// Kill/Death Ratio of Player
		/// </summary>
		double KillDeath { get; }
		/// <summary>
		/// Name of the Player's Current Rank
		/// </summary>
		string RankName { get; }
		/// <summary>
		/// Max Ranked Reached by Player
		/// </summary>
		int MaxRank { get; }
		/// <summary>
		/// Name of the Max Rank
		/// </summary>
		string MaxRankName { get; }
		/// <summary>
		/// Kill Per Match Ratio
		/// </summary>
		double KillPerMatch { get; }
		/// <summary>
		/// Death Per Match Ratio
		/// </summary>
		double DeathPerMatch { get; }
	}
}
