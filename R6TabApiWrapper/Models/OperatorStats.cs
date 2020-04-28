using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	public class OperatorStats
	{
		[JsonProperty("wins")]
		public int Wins { get; internal set; }
		[JsonProperty("losses")]
		public int Losses { get; internal set; }
		[JsonProperty("kills")]
		public int Kills { get; internal set; }
		[JsonProperty("deaths")]
		public int Deaths { get; internal set; }
		[JsonProperty("timeplayed")]
		public int TimePlayed { get; internal set; }
		[JsonProperty("kd")]
		private string _kd { get; set; }
		[JsonIgnore]
		public double KD { get
			{
				return Convert.ToDouble(_kd);
			} }
		/// <summary>
		/// Win Rate as Percentage
		/// </summary>
		[JsonProperty("winrate")]
		public int WinRate { get; internal set; }
	}
}
