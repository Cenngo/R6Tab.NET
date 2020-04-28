using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Models
{
    public class Api
    {
        [JsonProperty("code")]
        public string CodeStatus { get; internal set; }
    }
}
