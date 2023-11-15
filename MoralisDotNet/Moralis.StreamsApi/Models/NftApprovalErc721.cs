﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class NftApprovalErc721
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

        [DataMember(Name = "approved", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "approved")]
        [System.Text.Json.Serialization.JsonPropertyName("approved")]
        public string Approved { get; set; }

        [DataMember(Name = "tokenId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenId")]
        [System.Text.Json.Serialization.JsonPropertyName("tokenId")]
        public string TokenId { get; set; }

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
    }
}
