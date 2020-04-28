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
		[JsonProperty("id")]
		public string Id { get; internal set; }
		[JsonProperty("type")]
		public string Type { get; internal set; }

		[JsonProperty("overall")]
		public OperatorStats OverallStats { get; internal set; }
		[JsonProperty("seasonal")]
		public OperatorStats SeasonalStats { get; internal set; }
	}
}
