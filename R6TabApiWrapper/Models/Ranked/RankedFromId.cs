using Newtonsoft.Json;
using System;
using System.Drawing;

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
        /// <summary>
        /// Total Number of Kills Across Regions
        /// </summary>
        [JsonProperty("allkills")]
        public int AllKills { get; internal set; }
        /// <summary>
        /// Total Number of Deaths Across Regions
        /// </summary>
        [JsonProperty("alldeaths")]
        public int AllDeaths { get; internal set; }
        /// <summary>
        /// Total Number of Wins Across Regions
        /// </summary>
        [JsonProperty("allwins")]
        public int AllWins { get; internal set; }
        /// <summary>
        /// Total Number of Losses Across Regions
        /// </summary>
        [JsonProperty("alllosses")]
        public int AllLosses { get; internal set; }
        /// <summary>
        /// Total Number of Abandons Across Regions
        /// </summary>
        [JsonProperty("allabandons")]
        public int AllAbandons { get; internal set; }
        /// <summary>
        /// Max Mmr Achieved in Any Region
        /// </summary>
        [JsonProperty("maxmmr")]
        public int MaxMmr { get; internal set; }
        /// <summary>
        /// Name of the Rank in the Active Region of the Player
        /// </summary>
        [JsonProperty("rankname")]
        public string RankName { get; internal set; }
        /// <summary>
        /// Name of the Max Rank Achieved in Any Region
        /// </summary>
        [JsonProperty("maxrankname")]
        public string MaxRankName { get; internal set; }
        /// <summary>
        /// Top Region of the Player
        /// </summary>
        [JsonProperty("topregion")]
        public string TopRegion { get; internal set; }
        /// <summary>
        /// Actual Mmr in the Active Region of the Player
        /// </summary>
        [JsonProperty("actualmmr")]
        public int ActualMmr { get; internal set; }
        /// <summary>
        /// Total Number of Matches Played Across Regions
        /// </summary>
        [JsonProperty("allmatches")]
        public int AllMatches { get; internal set; }
        [JsonProperty("allkd")]
        internal string _allkd { get; set; }
        /// <summary>
        /// General Kill/Death Ratio Covering All Region Kills / Deaths
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
        /// General Kill/Death Percentage Covering All Region Wins / Losses
        /// </summary>
        [JsonIgnore]
        public double AllWinLose
        {
            get
            {
                return Convert.ToDouble(_allWl.Remove(_allWl.Length - 1));
            }
        }
        /// <summary>
        /// General Kill per Match Ratio
        /// </summary>
        [JsonProperty("killpermatch")]
        public double KillPerMatch { get; internal set; }
        /// <summary>
        /// General Death per Match Ratio
        /// </summary>
        [JsonProperty("deathspermatch")]
        public double DeathPerMatch { get; internal set; }
        /// <summary>
        /// Color of the Rank Banner
        /// </summary>
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
