using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class Log
    {
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string Tag { get; set; }

        [DataMember(Name = "streamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streamId")]
        [System.Text.Json.Serialization.JsonPropertyName("streamId")]
        public string StreamId { get; set; }

        [DataMember(Name = "logIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "logIndex")]
        [System.Text.Json.Serialization.JsonPropertyName("logIndex")]
        public string LogIndex { get; set; }

        [DataMember(Name = "transactionHash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactionHash")]
        [System.Text.Json.Serialization.JsonPropertyName("transactionHash")]
        public string TransactionHash { get; set; }

        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string Address { get; set; }

        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string Data { get; set; }

        [DataMember(Name = "topic0", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "topic0")]
        [System.Text.Json.Serialization.JsonPropertyName("topic0")]
        public string Topic0 { get; set; }

        [DataMember(Name = "topic1", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "topic1")]
        [System.Text.Json.Serialization.JsonPropertyName("topic1")]
        public string Topic1 { get; set; }

        [DataMember(Name = "topic2", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "topic2")]
        [System.Text.Json.Serialization.JsonPropertyName("topic2")]
        public string Topic2 { get; set; }

        [DataMember(Name = "topic3", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "topic3")]
        [System.Text.Json.Serialization.JsonPropertyName("topic3")]
        public string Topic3 { get; set; }
    }
}
