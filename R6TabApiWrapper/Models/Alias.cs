using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	/// <summary>
	/// Alias Data of User
	/// </summary>
	public class Alias
	{
		[JsonProperty("name")]
		public string Name { get; internal  set; }
		[JsonProperty("utime")]
		public int UTime { get; internal set; }
		[JsonProperty("date")]
		public string Date { get; internal set; }
	}
}
