using Newtonsoft.Json;
using System;

namespace R6Api.Models
{
    public class OperatorStats
    {
        /// <summary>
        /// Number of Wins Achieved with the Operator
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; internal set; }
        /// <summary>
        /// Number of Losses Achieved with the Operator
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; internal set; }
        /// <summary>
        /// Number of Kills Achieved with the Operator
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; internal set; }
        /// <summary>
        /// Number of Deaths Achieved with the Operator
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; internal set; }
        /// <summary>
        /// Time Played with the Operator
        /// </summary>
        [JsonProperty("timeplayed")]
        public int TimePlayed { get; internal set; }
        [JsonProperty("kd")]
        private string _kd { get; set; }
        /// <summary>
        /// Kill/Death Ratio Achieved with the Operator
        /// </summary>
        [JsonIgnore]
        public double KD
        {
            get
            {
                return Convert.ToDouble(_kd);
            }
        }
        /// <summary>
        /// Win/Lose Rate Achieved with the Operator
        /// </summary>
        [JsonProperty("winrate")]
        public int WinRate { get; internal set; }
    }
}
