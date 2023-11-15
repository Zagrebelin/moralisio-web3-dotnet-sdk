using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class WebhookBlock
    {
        [DataMember(Name = "number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "number")]
        [System.Text.Json.Serialization.JsonPropertyName("number")]
        public string Number { get; set; }

        [DataMember(Name = "hash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hash")]
        [System.Text.Json.Serialization.JsonPropertyName("hash")]
        public string Hash { get; set; }

        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timestamp")]
        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        public DateTime When => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(int.Parse(Timestamp));
    }
}