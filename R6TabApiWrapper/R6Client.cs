using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using R6Api.Enums;
using R6Api.Models;
using R6Api.Models.SearchResults;
using R6Api.Models.Stats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;

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
        public R6Client ( R6Config config )
        {
            _config = config;
            _httpClient = new HttpClient();
        }

        /// <summary>
        /// Parse Players by UserId
        /// </summary>
        /// <param name="userId">UserId of the Player</param>
        /// <param name="time">Optional Time Stamp to Avoid Caching</param>
        /// <returns>DataById under normal operation OR Error Message</returns>
        /// <example>
        ///	<code>
        ///		DataById result = client.ParseById(9bd44bde-9c48-48ae-9c2b-4e11e4b16083); 	
        /// </code>
        /// </example>
        public DataById ParseById ( string userId, DateTimeOffset? time = null )
        {
            CheckToken();
            var requestUri = new UriBuilder(_config.BaseUrl) { Path = $"player/{userId}" };

            var query = HttpUtility.ParseQueryString(requestUri.Query);

            if (time != null)
                query["u"] = time?.ToUnixTimeSeconds().ToString();
            else if (_config.AutoCacheAvoidance == true)
                query["u"] = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();

            query["cid"] = _config.ApiKey;
            requestUri.Query = query.ToString();

            var html = string.Empty;
            var response = ( _httpClient.GetAsync(requestUri.Uri) ).Result;
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
        /// <returns>DataByName under normal operation OR Error Message</returns>
        /// <example>
        /// <code>
        ///		DataByName result = client.ParseByName("baiier", Platform.Uplay);
        /// </code>
        /// </example>
        public DataByName ParseByName ( string username, Platform platform, DateTimeOffset? time = null )
        {
            CheckToken();
            var requestUri = new UriBuilder(_config.BaseUrl) { Path = $"search/{platform.ToString().ToLower()}/{username}" };

            var query = HttpUtility.ParseQueryString(requestUri.Query);

            if (time != null)
                query["u"] = time?.ToUnixTimeSeconds().ToString();
            else if (_config.AutoCacheAvoidance == true)
                query["u"] = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();

            query["cid"] = _config.ApiKey;
            requestUri.Query = query.ToString();

            var html = string.Empty;
            var response = _httpClient.GetAsync(requestUri.Uri).Result;
            using var sr = new StreamReader(response.Content.ReadAsStreamAsync().Result);
            html = sr.ReadToEnd();

            var jObject = JObject.Parse(html);

            var data = JsonConvert.DeserializeObject<DataByName>(html);

            if (data.Status != 200)
                return data;

            if (jObject["players"].Children().Any())
            {
                data.FoundPlayers = jObject["players"].ToObject<Dictionary<string, Player>>();
            }
            return data;
        }

        /// <summary>
        /// Get Updated Player Information
        /// </summary>
        /// <param name="userId">UserId of the Player</param>
        /// <returns>DataById under normal operation OR Error Message</returns>
        /// <example>
        /// <code>
        ///		var result = client.UpdatePlayer(9bd44bde-9c48-48ae-9c2b-4e11e4b16083);
        /// </code>
        /// </example>
        public DataById UpdatePlayer ( string userId )
        {
            CheckToken();
            var requestUri = new UriBuilder(_config.BaseUrl) { Path = $"update/{userId}" };

            var html = string.Empty;
            var response = ( _httpClient.GetAsync(requestUri.Uri) ).Result;
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
        /// <returns>LeaderboardData under normal operation OR Error Message</returns>
        /// <example>
        /// <code>
        ///		var leaderboard = client.GetLeaderboard(Platform.Uplay, Region.All);
        /// </code>
        /// </example>
        public LeaderboardData GetLeaderboard ( Platform platform, Region region, DateTimeOffset? time = null )
        {
            CheckToken();
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

        private static DataById ParseIdData ( string json )
        {
            var jObject = JObject.Parse(json);

            var userData = JsonConvert.DeserializeObject<DataById>(json);
            if (userData.Status != 200)
                return userData;

            if (jObject["social"].Children().Any())
                userData.Social = jObject["social"].ToObject<Social>();

            userData.Stats.Casual = jObject["stats"].ToObject<CasualStats>();
            userData.Stats.Ranked = jObject["stats"].ToObject<RankedStats>();
            userData.Stats.GeneralPvP = jObject["stats"].ToObject<GeneralStatsPvP>();
            userData.Stats.GeneralPvE = jObject["stats"].ToObject<GeneralStatsPvE>();

            userData.Ranked.AS = jObject["ranked"].ToObject<RankedAS>();
            userData.Ranked.NA = jObject["ranked"].ToObject<RankedNA>();
            userData.Ranked.EU = jObject["ranked"].ToObject<RankedEU>();

            userData.Operators = new Models.Operators();
            userData.Operators.OpStats = jObject["operators"].ToObject<Dictionary<string, OperatorData>>();

            if (jObject["aliases"].Children().Any())
            {
                userData.Aliases = jObject["aliases"].ToObject<Dictionary<int, Alias>>().Values;
            }

            return userData;
        }

        private void CheckToken ( )
        {
            if (string.IsNullOrEmpty(_config.ApiKey))
                throw new InvalidOperationException("No Api Key Found!");
        }
    }
}
