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
		/// <inheritdoc/>
		[JsonProperty("p_user")]
		public string User { get; internal set; }
		/// <summary>
		/// Username of Player
		/// </summary>
		[JsonProperty("p_name")]
		public string Name { get; internal set; }
		[JsonProperty("p_platform")]
		internal string _platform { get; set; }
		/// <summary>
		/// Platform the User Profile is Registered to
		/// </summary>
		[JsonIgnore]
		public Platform Platform { get
			{
				return (Platform)(Enum.Parse(typeof(Platform), _platform, true));
		} }
		/// <inheritdoc/>
		public string GetAvatar()
		{
			return $"https://ubisoft-avatars.akamaized.net/{User}/default_146_146.png";
		}
	}
}
