using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class Erc20Approval
    {
        [DataMember(Name = "transactionHash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactionHash")]
        [System.Text.Json.Serialization.JsonPropertyName("transactionHash")]
        public string TransactionHash { get; set; }

        [DataMember(Name = "contract", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contract")]
        [System.Text.Json.Serialization.JsonPropertyName("contract")]
        public string Contract { get; set; }

        [DataMember(Name = "logIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "logIndex")]
        [System.Text.Json.Serialization.JsonPropertyName("logIndex")]
        public string LogIndex { get; set; }

        [DataMember(Name = "tag", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string Tag { get; set; }

        [DataMember(Name = "owner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "owner")]
        [System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string Owner { get; set; }

        [DataMember(Name = "spender", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "spender")]
        [System.Text.Json.Serialization.JsonPropertyName("spender")]
        public string Spender { get; set; }

        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

        [DataMember(Name = "tokenDecimals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenDecimals")]
        [System.Text.Json.Serialization.JsonPropertyName("tokenDecimals")]
        public string TokenDecimals { get; set; }

        [DataMember(Name = "tokenName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenName")]
        [System.Text.Json.Serialization.JsonPropertyName("tokenName")]
        public string TokenName { get; set; }

        [DataMember(Name = "tokenSymbol", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenSymbol")]
        [System.Text.Json.Serialization.JsonPropertyName("tokenSymbol")]
        public string TokenSymbol { get; set; }

        [DataMember(Name = "valueWithDecimals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "valueWithDecimals")]
        [System.Text.Json.Serialization.JsonPropertyName("valueWithDecimals")]
        public string ValueWithDecimals { get; set; }
    }
}
