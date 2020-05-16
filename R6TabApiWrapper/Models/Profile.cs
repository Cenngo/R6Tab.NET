using Newtonsoft.Json;
using R6Api.Models.Bases;

namespace R6Api.Models
{
    public class Profile : PlayerBase
    {
        [JsonProperty("verified")]
        public bool IsVerified { get; internal set; }
    }
}
