using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using R6Api.Enums;
using R6Api.Models;
using R6Api.Models.SearchResults;
using R6Api.Models.Stats;
using R6TabApiWrapper.Enums;
using R6TabApiWrapper.Models.SearchResults;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace R6Api
{
	/// <summary>
	/// R6 Client to Handle Api Requests
	/// </summary>
	public class R6Client
	{

		private readonly HttpClient _httpClient;
		private readonly R6Config _config;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="config"> Config of the Client </param>
		public R6Client ( R6Config config = null )
		{
			_config = config ?? new R6Config();
			_httpClient = new HttpClient();
		}

		/// <summary>
		/// Parse Players by UserId
		/// </summary>
		/// <param name="userId">UserId of the Player</param>
		/// <param name="time">Optional Time Stamp to Avoid Caching</param>
		/// <returns></returns>
		public DataById ParseById ( string userId, DateTimeOffset? time = null )
		{
			var requestUri = new UriBuilder(_config.BaseUrl) { Path = $"player/{userId}" };

			if (time != null)
				requestUri.Query = $"u={time?.ToUnixTimeSeconds()}";
			else if (_config.AutoCacheAvoidance == true)
				requestUri.Query = $"u={DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";

			var html = string.Empty;
			var response = (_httpClient.GetAsync(requestUri.Uri)).Result;
			using var sr = new StreamReader(response.Content.ReadAsStreamAsync().Result);
				html = sr.ReadToEnd();

			return ParseIdData(html);
		}

		/// <summary>
		/// Search Players from a Given Name
		/// </summary>
		/// <param name="username">Username of the Player</param>
		/// <param name="platform">Platform of the User</param>
		/// <param name="time">Optional Time Stamp to Avoid Caching</param>
		/// <returns></returns>
		public DataByName ParseByName ( string username, Platform platform, DateTimeOffset? time = null )
		{
			var requestUri = new UriBuilder(_config.BaseUrl) { Path = $"search/{platform.ToString().ToLower()}/{username}" };

			if (time != null)
				requestUri.Query = $"u={time?.ToUnixTimeSeconds()}";
			else if (_config.AutoCacheAvoidance == true)
				requestUri.Query = $"u={DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";

			var html = string.Empty;
			var response = _httpClient.GetAsync(requestUri.Uri).Result;
			using var sr = new StreamReader(response.Content.ReadAsStreamAsync().Result);
			html = sr.ReadToEnd();

			var jObject = JObject.Parse(html);

			var data = JsonConvert.DeserializeObject<DataByName>(html);
			
			if(jObject["players"].Children().Count() != 0)
			{
				data.FoundPlayers = jObject["players"].ToObject<Dictionary<string, Player>>();
			}
			return data;
		}

		/// <summary>
		/// Get Updated Player Information
		/// </summary>
		/// <param name="userId">UserId of the Player</param>
		/// <returns></returns>
		public DataById UpdatePlayer(string userId )
		{
			var requestUri = new UriBuilder(_config.BaseUrl) { Path = $"update/{userId}" };

			var html = string.Empty;
			var response = (_httpClient.GetAsync(requestUri.Uri)).Result;
			using var sr = new StreamReader(response.Content.ReadAsStreamAsync().Result);
			html = sr.ReadToEnd();

			return ParseIdData(html);
		}

		/// <summary>
		/// Get Leaderboard of a Region and Platform (updated every hour)
		/// </summary>
		/// <param name="platform">Platform of the Leaderboard</param>
		/// <param name="region">Region of the Leaderboard</param>
		/// <param name="time">Optional Time Stamp to Avoid Caching</param>
		/// <returns></returns>
		public LeaderboardData GetLeaderboard(Platform platform, Region region, DateTimeOffset? time = null)
		{
			var requestUri = new UriBuilder(_config.BaseUrl) { Path = $"leaderboard/{platform.ToString().ToLower()}/{region.ToString().ToLower()}" };

			if (time != null)
				requestUri.Query = $"u={time?.ToUnixTimeSeconds()}";
			else if (_config.AutoCacheAvoidance == true)
				requestUri.Query = $"u={DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";

			var html = string.Empty;
			var response = _httpClient.GetAsync(requestUri.Uri).Result;
			using var sr = new StreamReader(response.Content.ReadAsStreamAsync().Result);
			html = sr.ReadToEnd();

			return JsonConvert.DeserializeObject<LeaderboardData>(html);
		}

		private DataById ParseIdData(string json )
		{
			var userData = JsonConvert.DeserializeObject<DataById>(json);
			var jObject = JObject.Parse(json);

			userData.Stats.Casual = jObject["stats"].ToObject<CasualStats>();
			userData.Stats.Ranked = jObject["stats"].ToObject<RankedStats>();
			userData.Stats.GeneralPvP = jObject["stats"].ToObject<GeneralStatsPvP>();
			userData.Stats.GeneralPvE = jObject["stats"].ToObject<GeneralStatsPvE>();

			userData.Ranked.AS = jObject["ranked"].ToObject<RankedAS>();
			userData.Ranked.NA = jObject["ranked"].ToObject<RankedNA>();
			userData.Ranked.EU = jObject["ranked"].ToObject<RankedEU>();

			if(jObject["aliases"].Children().Count() != 0)
			{
				userData.Aliases = jObject["aliases"].ToObject<Dictionary<int, Alias>>().Values;
			}

			return userData;
		}
	}
}
