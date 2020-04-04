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

namespace R6Api
{
	/// <summary>
	/// R6 Client to Handle Api Requests
	/// </summary>
	public class R6Client
	{

		private readonly HttpClient _httpClient;
		private readonly Uri _baseURi;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="baseUri">Base Url of the Api(defaulted as: https://r6.apitab.com/) </param>
		public R6Client ( string baseUri = null )
		{
			_baseURi = new Uri(baseUri ?? " https://r6.apitab.com/");
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
			var requestUri = new UriBuilder(_baseURi) { Path = $"player/{userId}" };

			if (time != null)
				requestUri.Query = $"u={time?.ToUnixTimeSeconds()}";

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
			var requestUri = new UriBuilder(_baseURi) { Path = $"search/{platform.ToString().ToLower()}/{username}" };

			if (time != null)
				requestUri.Query = $"u={time?.ToUnixTimeSeconds()}";

			var html = string.Empty;
			var response = _httpClient.GetAsync(requestUri.Uri).Result;
			using var sr = new StreamReader(response.Content.ReadAsStreamAsync().Result);
			html = sr.ReadToEnd();

			return JsonConvert.DeserializeObject<DataByName>(html);
		}

		/// <summary>
		/// Get Updated Player Information
		/// </summary>
		/// <param name="userId">UserId of the Player</param>
		/// <returns></returns>
		public DataById UpdatePlayer(string userId )
		{
			var requestUri = new UriBuilder(_baseURi) { Path = $"update/{userId}" };

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
			var requestUri = new UriBuilder(_baseURi) { Path = $"leaderboard/{platform.ToString().ToLower()}/{region.ToString().ToLower()}" };

			if (time != null)
				requestUri.Query = $"u={time?.ToUnixTimeSeconds()}";

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

			userData.Aliases = jObject["aliases"].ToObject<Dictionary<int, Alias>>().Values;

			return userData;
		}
	}
}
