using Newtonsoft.Json;
using R6Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models.SearchResults
{
    public class SearchResult : ISearchResult
    {
        /// <summary>
        /// Is the Used Request Token Authorized
        /// </summary>
        [JsonProperty("authorized")]
        public bool Authorized { get; internal set; } = true;
        [JsonProperty("API")]
        public Api Api { get; internal set; }
        /// <inheritdoc/>
        [JsonProperty("status")]
        public int Status { get; internal set; }
        /// <summary>
        /// Error Message
        /// </summary>
        [JsonProperty("error")]
        public string ErrorMessage { get; internal set; }
        /// <summary>
        /// Further Information About Request
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; internal set; }
        /// <summary>
        /// Contact Address for Support
        /// </summary>
        [JsonProperty("contact")]
        public string Contact { get; internal set; }
    }
}
