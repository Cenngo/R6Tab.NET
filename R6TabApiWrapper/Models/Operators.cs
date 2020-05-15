using System.Collections.Generic;
using System.Linq;

namespace R6Api.Models
{
    /// <summary>
    /// Every Property in this class is in the form of a Dictionary where key value is the name of the operator, with a capital first letter. 
    /// </summary>
    public class Operators
    {
        public Dictionary<string, OperatorData> OpStats { get; internal set; }
        /// <summary>
        /// Operators with Most Play Time Overall
        /// </summary>
        public Dictionary<string, OperatorData> TopPlayedOverall
        {
            get
            {
                var topOps = new Dictionary<string, OperatorData>();

                var Values = OpStats.Select(x => x.Value.OverallStats.TimePlayed);

                foreach (var op in OpStats)
                {
                    if (op.Value.OverallStats.TimePlayed == Values.Max())
                        topOps.Add(op.Key, op.Value);
                }
                return topOps;
            }
        }

        /// <summary>
        /// Operators with Most Wins Overall
        /// </summary>
        public Dictionary<string, OperatorData> TopWinsOverall
        {
            get
            {
                var topOps = new Dictionary<string, OperatorData>();

                var Values = OpStats.Select(x => x.Value.OverallStats.Wins);

                foreach (var op in OpStats)
                {
                    if (op.Value.OverallStats.Wins == Values.Max())
                        topOps.Add(op.Key, op.Value);
                }
                return topOps;
            }
        }

        /// <summary>
        /// Operators with Most Losses Overall
        /// </summary>
        public Dictionary<string, OperatorData> TopLossesOverall
        {
            get
            {
                var topOps = new Dictionary<string, OperatorData>();

                var Values = OpStats.Select(x => x.Value.OverallStats.Losses);

                foreach (var op in OpStats)
                {
                    if (op.Value.OverallStats.Losses == Values.Max())
                        topOps.Add(op.Key, op.Value);
                }
                return topOps;
            }
        }

        /// <summary>
        /// Operators with Most Kills Overall
        /// </summary>
        public Dictionary<string, OperatorData> TopKillsOverall
        {
            get
            {
                var topOps = new Dictionary<string, OperatorData>();

                var Values = OpStats.Select(x => x.Value.OverallStats.Kills);

                foreach (var op in OpStats)
                {
                    if (op.Value.OverallStats.Kills == Values.Max())
                        topOps.Add(op.Key, op.Value);
                }
                return topOps;
            }
        }

        /// <summary>
        /// Operators with Most Deaths Overall
        /// </summary>
        public Dictionary<string, OperatorData> TopDeathsOverall
        {
            get
            {
                var topOps = new Dictionary<string, OperatorData>();

                var Values = OpStats.Select(x => x.Value.OverallStats.Deaths);

                foreach (var op in OpStats)
                {
                    if (op.Value.OverallStats.Deaths == Values.Max())
                        topOps.Add(op.Key, op.Value);
                }
                return topOps;
            }
        }

        /// <summary>
        /// Operators with Most Play Time Seasonal
        /// </summary>
        public Dictionary<string, OperatorData> TopPlayedSeasonal
        {
            get
            {
                var topOps = new Dictionary<string, OperatorData>();

                var Values = OpStats.Select(x => x.Value.SeasonalStats.TimePlayed);

                foreach (var op in OpStats)
                {
                    if (op.Value.SeasonalStats.TimePlayed == Values.Max())
                        topOps.Add(op.Key, op.Value);
                }
                return topOps;
            }
        }

        /// <summary>
        /// Operators with Most Wins Seasonal
        /// </summary>
        public Dictionary<string, OperatorData> TopWinsSeasonal
        {
            get
            {
                var topOps = new Dictionary<string, OperatorData>();

                var Values = OpStats.Select(x => x.Value.SeasonalStats.Wins);

                foreach (var op in OpStats)
                {
                    if (op.Value.SeasonalStats.Wins == Values.Max())
                        topOps.Add(op.Key, op.Value);
                }
                return topOps;
            }
        }

        /// <summary>
        /// Operators with Most Losses Seasonal
        /// </summary>
        public Dictionary<string, OperatorData> TopLossesSeasonal
        {
            get
            {
                var topOps = new Dictionary<string, OperatorData>();

                var Values = OpStats.Select(x => x.Value.SeasonalStats.Losses);

                foreach (var op in OpStats)
                {
                    if (op.Value.SeasonalStats.Losses == Values.Max())
                        topOps.Add(op.Key, op.Value);
                }
                return topOps;
            }
        }

        /// <summary>
        /// Operators with Most Kills Seasonal
        /// </summary>
        public Dictionary<string, OperatorData> TopKillsSeasonal
        {
            get
            {
                var topOps = new Dictionary<string, OperatorData>();

                var Values = OpStats.Select(x => x.Value.SeasonalStats.Kills);

                foreach (var op in OpStats)
                {
                    if (op.Value.SeasonalStats.Kills == Values.Max())
                        topOps.Add(op.Key, op.Value);
                }
                return topOps;
            }
        }

        /// <summary>
        /// Operators with Most Deaths Seasonal
        /// </summary>
        public Dictionary<string, OperatorData> TopDeathsSeasonal
        {
            get
            {
                var topOps = new Dictionary<string, OperatorData>();

                var Values = OpStats.Select(x => x.Value.SeasonalStats.Deaths);

                foreach (var op in OpStats)
                {
                    if (op.Value.SeasonalStats.Deaths == Values.Max())
                        topOps.Add(op.Key, op.Value);
                }
                return topOps;
            }
        }
    }
}
