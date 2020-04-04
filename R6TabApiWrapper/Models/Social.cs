using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	public class Social
	{
		[JsonProperty("status")]
		public int Status { get; internal set; }
		[JsonProperty("utime")]
		public int UTime { get; internal set; }
		[JsonProperty("uplay_user")]
		public string UplayUser { get; internal set; }
		[JsonProperty("uplay_name")]
		public string UplayName { get; internal set; }
		[JsonProperty("twitter")]
		public string Twitter { get; internal set; }
		[JsonProperty("instagram")]
		public string Instagram { get; internal set; }
		[JsonProperty("twitch")]
		public string Twitch { get; internal set; }
		[JsonProperty("twitch_id")]
		public string TwitchId { get; internal set; }
		[JsonProperty("youtube")]
		public string Youtube { get; internal set; }
		[JsonProperty("mixer")]
		public string Mixer { get; internal set; }
		[JsonProperty("discord")]
		public string Discord { get; internal set; }
		[JsonProperty("discord_id")]
		public string DiscordId { get; internal set; }
		[JsonProperty("esl")]
		public string Esl { get; internal set; }
		[JsonProperty("bio")]
		public string Bio { get; internal set; }
		[JsonProperty("background")]
		public string Background { get; internal set; }
		[JsonProperty("embed")]
		public string Embed { get; internal set; }
		[JsonProperty("aliases_hide")]
		public int AliasesHide { get; internal set; }
		[JsonProperty("twitch_display")]
		public int TwitchDisplay { get; internal set; }
		[JsonProperty("premium")]
		public Premium Premium { get; internal set; }
		[JsonProperty("is_premium")]
		public bool IsPremium { get; internal set; }
	}

	public class Premium
	{
		[JsonProperty("tabwire")]
		public bool TabWire { get; internal set; }
		[JsonProperty("discord")]
		public bool Discord { get; internal set; }
		[JsonProperty("twitch")]
		public bool Twitch { get; internal set; }
	}
}
