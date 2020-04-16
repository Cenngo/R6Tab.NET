using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace R6Api.Models.Ranked
{
	/// <summary>
	/// Detailed Ranked Info Parsed from Id Search for Rainbow6
	/// </summary>
	public class RankedFromId : RankedBase
	{
		/// <summary>
		/// Ranked Data for AS Region
		/// </summary>
		[JsonIgnore]
		public RankedAS AS { get; internal set; }
		/// <summary>
		/// Ranked Data for EU Region
		/// </summary>
		[JsonIgnore]
		public RankedEU EU { get; internal set; }
		/// <summary>
		/// Ranked Data for NA Region
		/// </summary>
		[JsonIgnore]
		public RankedNA NA { get; internal set; }
		[JsonProperty("allkills")]
		public int AllKills { get; internal set; }
		[JsonProperty("alldeaths")]
		public int AllDeaths { get; internal set; }
		[JsonProperty("allwins")]
		public int AllWins { get; internal set; }
		[JsonProperty("alllosses")]
		public int AllLosses { get; internal set; }
		[JsonProperty("allabandons")]
		public int AllAbandons { get; internal set; }
		[JsonProperty("maxmmr")]
		public int MaxMmr { get; internal set; }
		[JsonProperty("rankname")]
		public string RankName { get; internal set; }
		[JsonProperty("maxrankname")]
		public string MaxRankName { get; internal set; }
		[JsonProperty("topregion")]
		public string TopRegion { get; internal set; }
		[JsonProperty("actualmmr")]
		public int ActualMmr { get; internal set; }
		[JsonProperty("allmatches")]
		public int AllMatches { get; internal set; }
		[JsonProperty("allkd")]
		internal string _allkd { get; set; }
		/// <summary>
		/// Kill/Death Ratio as Percentage
		/// </summary>
		[JsonIgnore]
		public double AllKillDeath
		{
			get
			{
				return Convert.ToDouble(_allkd);
			}
		}
		[JsonProperty("allwl")]
		internal string _allWl { get; set; }
		/// <summary>
		/// Win/Lose Ratio as Percentage
		/// </summary>
		[JsonIgnore]
		public double AllWinLose
		{
			get
			{
				return Convert.ToDouble(_allWl.Remove(_allWl.Length - 1));
			}
		}
		[JsonProperty("killpermatch")]
		public double KillPerMatch { get; internal set; }
		[JsonProperty("deathspermatch")]
		public double DeathPerMatch { get; internal set; }
		public Color RankColor
		{
			get
			{
				var rankName = RankName.Split(" ")[0].ToLower();

				Color color;

				switch (rankName)
				{
					case "copper":
						color = Color.FromArgb(144, 4, 11);
						break;
					case "bronze":
						color = Color.FromArgb(116, 74, 29);
						break;
					case "silver":
						color = Color.FromArgb(161, 161, 161);
						break;
					case "gold":
						color = Color.FromArgb(227, 198, 30);
						break;
					case "platinum":
						color = Color.FromArgb(37, 169, 162);
						break;
					case "diamond":
						color = Color.FromArgb(154, 124, 244);
						break;
					case "champion":
						color = Color.FromArgb(192, 15, 89);
						break;
					default:
						color = Color.White;
						break;
				}

				return color;
			}
		}
	}
}
