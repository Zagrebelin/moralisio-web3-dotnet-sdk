using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class NftTransfer
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

        [DataMember(Name = "tokenContractType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenContractType")]
        [System.Text.Json.Serialization.JsonPropertyName("tokenContractType")]
        public string TokenContractType { get; set; }

        [DataMember(Name = "tokenName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenName")]
        [System.Text.Json.Serialization.JsonPropertyName("tokenName")]
        public string TokenName { get; set; }

        [DataMember(Name = "tokenSymbol", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenSymbol")]
        [System.Text.Json.Serialization.JsonPropertyName("tokenSymbol")]
        public string TokenSymbol { get; set; }

        [DataMember(Name = "operator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "operator")]
        [System.Text.Json.Serialization.JsonPropertyName("operator")]
        public string Operator { get; set; }

        [DataMember(Name = "from", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "from")]
        [System.Text.Json.Serialization.JsonPropertyName("from")]
        public string From { get; set; }

        [DataMember(Name = "to", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "to")]
        [System.Text.Json.Serialization.JsonPropertyName("to")]
        public string To { get; set; }

        [DataMember(Name = "tokenId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenId")]
        [System.Text.Json.Serialization.JsonPropertyName("tokenId")]
        public string TokenId { get; set; }

        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public string Amount { get; set; }
    }
}
