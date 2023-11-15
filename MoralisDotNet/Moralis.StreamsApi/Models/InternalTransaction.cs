using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class InternalTransaction
    {
        [DataMember(Name = "from", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "from")]
        [System.Text.Json.Serialization.JsonPropertyName("from")]
        public string From { get; set; }

        [DataMember(Name = "to", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "to")]
        [System.Text.Json.Serialization.JsonPropertyName("to")]
        public string To { get; set; }

        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

        [DataMember(Name = "transactionHash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactionHash")]
        [System.Text.Json.Serialization.JsonPropertyName("transactionHash")]
        public string TransactionHash { get; set; }

        [DataMember(Name = "gas", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gas")]
        [System.Text.Json.Serialization.JsonPropertyName("gas")]
        public string Gas { get; set; }

        [DataMember(Name = "streamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streamId")]
        [System.Text.Json.Serialization.JsonPropertyName("streamId")]
        public string StreamId { get; set; }

        [DataMember(Name = "tag", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string Tag { get; set; }

    }
}
