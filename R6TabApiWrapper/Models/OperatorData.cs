﻿using Newtonsoft.Json;
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
		/// Unique Id of the Operator
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; internal set; }
		/// <summary>
		/// Type of the Operator (Attacker / Defender)
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; internal set; }
		/// <summary>
		/// Overall Stats for the Operator
		/// </summary>
		[JsonProperty("overall")]
		public OperatorStats OverallStats { get; internal set; }
		/// <summary>
		/// Seasonal Stats for the Operator
		/// </summary>
		[JsonProperty("seasonal")]
		public OperatorStats SeasonalStats { get; internal set; }
	}
}
