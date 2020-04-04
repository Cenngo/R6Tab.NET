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
		int Kills { get; }
		int Deaths { get; }
		int Wins { get; }
		int Losses { get; }
		int Abandons { get; }
		int MaxMmr { get; }
		int Champ { get; }
		int MmrChange { get; }
		int ActualMmr { get; }
		int Matches { get; }
		double WinLose { get; }
		double KillDeath { get; }
		string RankName { get; }
		int MaxRank { get; }
		string MaxRankName { get; }
		double KillPerMatch { get; }
		double DeathPerMatch { get; }
	}
}
