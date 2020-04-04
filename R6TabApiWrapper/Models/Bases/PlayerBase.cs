using Newtonsoft.Json;
using R6Api.Enums;
using R6Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models.Bases
{
	public class PlayerBase : IPlayer
	{
		/// <summary>
		/// UserId of the Player
		/// </summary>
		[JsonProperty("p_user")]
		public string User { get; internal set; }
		[JsonProperty("p_name")]
		public string Name { get; internal set; }
		[JsonProperty("p_platform")]
		internal string _platform { get; set; }
		[JsonIgnore]
		public Platform Platform { get
			{
				return (Platform)(Enum.Parse(typeof(Platform), _platform, true));
		} }
		/// <summary>
		/// Get Profile Picture of Player
		/// </summary>
		/// <returns>Url of User Avatar</returns>
		public string GetAvatar()
		{
			return $"https://ubisoft-avatars.akamaized.net/{User}/default_146_146.png";
		}
	}
}
