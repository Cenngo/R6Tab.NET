using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	public class OperatorStats
	{
		public int Wins { get; internal set; }
		public int Losses { get; internal set; }
		public int Kills { get; internal set; }
		public int Deaths { get; internal set; }
		public int TimePlayed { get; internal set; }
	}
}
