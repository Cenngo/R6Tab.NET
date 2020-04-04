using Newtonsoft.Json;
using R6Api.Models.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
	public class Profile : PlayerBase
	{
		[JsonProperty("verified")]
		public bool IsVerified { get; internal set; }
	}
}
