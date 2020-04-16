using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace R6TabApiWrapper.Interfaces
{
	/// <summary>
	/// Ranked Data Template that Contains Rank Info for Rainbow6
	/// </summary>
	public interface IRankedData
	{
		int Rank { get; }
		string GetRankImg ();
	}
}
