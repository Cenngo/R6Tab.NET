using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using R6Api.Enums;

namespace R6Api.Models
{
	public class OperatorData
	{
		/// <summary>
		/// Operator Data as Sorted for Wins
		/// </summary>
		[JsonProperty("wins")]
		public IDictionary<string, int>  Wins { get; internal set; }
		/// <summary>
		/// Operator Data as Sorted for Losses
		/// </summary>
		[JsonProperty("losses")]
		public IDictionary<string, int> Losses { get; internal set; }
		/// <summary>
		/// Operator Data as Sorted for Kills
		/// </summary>
		[JsonProperty("kills")]
		public IDictionary<string, int> Kills { get; internal set; }
		/// <summary>
		/// Operator Data as Sorted for Deaths
		/// </summary>
		[JsonProperty("deaths")]
		public IDictionary<string, int> Deaths { get; internal set; }
		/// <summary>
		/// Operator Data as Sorted for Time Played
		/// </summary>
		[JsonProperty("timeplayed")]
		public IDictionary<string, int> TimePlayed { get; internal set; }

		/// <summary>
		/// Get a Collection Containing the Top Operator/Operators in Play-Time Category
		/// </summary>
		/// <returns>Collection of Operators With Most Play Time</returns>
		public IEnumerable<string> GetTopPlayed()
		{
			return GetTopOps(TimePlayed);
		}

		/// <summary>
		/// Get a Collection Containing the Top Operator/Operators in Wins Category
		/// </summary>
		/// <returns>Collection of Operators With Most Wins</returns>
		public IEnumerable<string> GetTopWins ()
		{
			return GetTopOps(Wins);
		}

		/// <summary>
		/// Get a Collection Containing the Top Operator/Operators in Losses Category
		/// </summary>
		/// <returns>Collection of Operators With Most Losses</returns>
		public IEnumerable<string> GetTopLosses()
		{
			return GetTopOps(Losses);
		}

		/// <summary>
		/// Get a Collection Containing the Top Operator/Operators in Kills Category
		/// </summary>
		/// <returns>Collection of Operators With Most Kills</returns>
		public IEnumerable<string> GetTopKills ()
		{
			return GetTopOps(Kills);
		}

		/// <summary>
		/// Get a Collection Containing the Top Operator/Operators in Deaths Category
		/// </summary>
		/// <returns>Collection of Operators With Most Deaths</returns>
		public IEnumerable<string> GetTopDeaths ()
		{
			return GetTopOps(Deaths);
		}

		/// <summary>
		/// Get a Decoded Version of the Operator Id
		/// </summary>
		/// <param name="opCode">Code Given to the Operator by R6Tab</param>
		/// <returns>Name of the Operator</returns>
		public string DecodeOperator(string opCode)
		{
			if (Operators.TryGetValue(opCode, out var opName))
				return opName;
			else
				return null;
		}

		/// <summary>
		/// Get Stats for a Specific Operator
		/// </summary>
		/// <param name="op">Operator</param>
		/// <returns></returns>
		public OperatorStats GetOperatorStats(Operators op)
		{
			var stats = new OperatorStats()
			{
				Wins = Wins.TryGetValue(Operators.First(x => x.Value == op.ToString()).Key, out var wins) ? wins : 0,
				Losses = Losses.TryGetValue(Operators.First(x => x.Value == op.ToString()).Key, out var losses) ? losses : 0,
				Kills = Kills.TryGetValue(Operators.First(x => x.Value == op.ToString()).Key, out var kills) ? kills : 0,
				Deaths = Deaths.TryGetValue(Operators.First(x => x.Value == op.ToString()).Key, out var deaths) ? deaths : 0,
				TimePlayed = TimePlayed.TryGetValue(Operators.First(x => x.Value == op.ToString()).Key, out var time) ? time : 0
			};
			return stats;
		}

		private IEnumerable<string> GetTopOps(IDictionary<string, int> collection)
		{
			var topOp = collection.Where(x => x.Value == TimePlayed.Values.Max());
			IList<string> topOpDecoded = new List<string>();

			foreach (var op in topOp)
			{
				if (Operators.TryGetValue(op.Key, out var opName))
					topOpDecoded.Add(opName);
			}

			return topOpDecoded;
		}

		private static readonly IDictionary<string, string> Operators = new Dictionary<string, string>()
		{
			{"2:1", "Smoke" },
			{"2:2", "Castle" },
			{"2:3", "Doc" },
			{"2:4", "Glaz" },
			{"2:5", "Blitz" },
			{"2:6", "Buck" },
			{"2:7", "Blackbeard" },
			{"2:8", "Capitao" },
			{"2:9", "Hibana" },
			{"2:A", "Jackal" },
			{"2:B", "Ying" },
			{"2:C", "Ela" },
			{"2:D", "Dokkaebi" },
			{"2:F", "Maestro" },
			{"3:1", "Mute" },
			{"3:2", "Ash" },
			{"3:3", "Rook" },
			{"3:4", "Fuze" },
			{"3:5", "IQ" },
			{"3:6", "Frost" },
			{"3:7", "Valkyrie" },
			{"3:8", "Caveira" },
			{"3:9", "Echo" },
			{"3:A", "Mira" },
			{"3:B", "Lesion" },
			{"3:C", "Zofia" },
			{"3:D", "Vigil" },
			{"3:E", "Lion" },
			{"3:F", "Alibi" },
			{"4:1", "Sledge" },
			{"4:2", "Pulse" },
			{"4:3", "Twitch" },
			{"4:4", "Kapkan" },
			{"4:5", "Jager" },
			{"4:E", "Finka" },
			{"5:1", "Thatcher" },
			{"5:2", "Thermite" },
			{"5:3", "Montagne" },
			{"5:4", "Tachanka" },
			{"5:5", "Bandit" },
			{"1:5", "GSG9_Recruit" },
			{"1:4", "Spetsnaz_Recruit" },
			{"1:3", "GIGN_Recruit" },
			{"1:2", "FBI_Recruit" },
			{"1:1", "SAS_Recruit" },
			{"2:11", "Nomad" },
			{"3:11", "Kaid" },
			{"3:10", "Clash" },
			{"2:10", "Maverick" },
			{"2:12", "Gridlock" },
			{"3:12", "Mozzie" }
		};
	}
}
