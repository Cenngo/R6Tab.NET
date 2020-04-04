using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	public class RefreshDetailed
	{
		[JsonProperty("queued")]
		public bool IsQueued { get; internal set; }
		[JsonProperty("possible")]
		public bool Possible { get; internal set; }
		[JsonProperty("qtime")]
		public int QTime { get; internal set; }
		[JsonProperty("utime")]
		public int UTime { get; internal set; }
		[JsonProperty("status")]
		public int Status { get; internal set; }
	}
}
