using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Interfaces
{
	/// <summary>
	/// Gamemode Stat Template for Rainbow6
	/// </summary>
	public interface IGamemodeStats
	{
		int Kills { get; }
		int Deaths { get; }
		int MatchesWon { get; }
		int MatchesLost { get; }
		int TimePlayed { get; }
		int HoursPlayed { get; }
		int MatchesPlayed { get; }
		double KillDeath { get; }
		double WinLose { get; }
	}
}
