using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	/// <summary>
	/// Custom R6Tab Data
	/// </summary>
	public class Custom
	{
		[JsonProperty("customurl")]
		public bool HasCustomUrl { get; internal set; }
		[JsonProperty("verified")]
		public bool IsVerified { get; internal set; }
		[JsonProperty("visitors")]
		public int VisitorCount { get; internal set; }
		[JsonProperty("banned")]
		public bool IsBanned { get; internal set; }
	}
}
