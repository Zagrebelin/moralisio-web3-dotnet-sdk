using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class Webhook
    {
        [DataMember(Name = "erc20Transfers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "erc20Transfers")]
        [System.Text.Json.Serialization.JsonPropertyName("erc20Transfers")]
        public List<Erc20Transfer> Erc20Transfers { get; set; }

        [DataMember(Name = "erc20Approvals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "erc20Approvals")]
        [System.Text.Json.Serialization.JsonPropertyName("erc20Approvals")]
        public List<Erc20Approval> Erc20Approvals { get; set; }

        [DataMember(Name = "nftTransfers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nftTransfers")]
        [System.Text.Json.Serialization.JsonPropertyName("nftTransfers")]
        public List<NftTransfer> NftTransfers { get; set; }

        [DataMember(Name = "nftApprovals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nftApprovals")]
        [System.Text.Json.Serialization.JsonPropertyName("nftApprovals")]
        public NftApproval NftApprovals { get; set; }

        [DataMember(Name = "block", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "block")]
        [System.Text.Json.Serialization.JsonPropertyName("block")]
        public WebhookBlock Block { get; set; }

        [DataMember(Name = "chainId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "chainId")]
        [System.Text.Json.Serialization.JsonPropertyName("chainId")]
        public string ChainId { get; set; }

        [DataMember(Name = "logs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "logs")]
        [System.Text.Json.Serialization.JsonPropertyName("logs")]
        public List<Log> Logs { get; set; }

        [DataMember(Name = "txs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "txs")]
        [System.Text.Json.Serialization.JsonPropertyName("txs")]
        public List<Transaction> Transactions { get; set; }

        [DataMember(Name = "txsInternal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "txsInternal")]
        [System.Text.Json.Serialization.JsonPropertyName("txsInternal")]
        public List<InternalTransaction> InternalTransactions { get; set; }

        [DataMember(Name = "abis", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "abis")]
        [System.Text.Json.Serialization.JsonPropertyName("abis")]
        public AbiItem Abis { get; set; }

        [DataMember(Name = "retries", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "retries")]
        [System.Text.Json.Serialization.JsonPropertyName("retries")]
        public int Retries { get; set; }

        [DataMember(Name = "confirmed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "confirmed")]
        [System.Text.Json.Serialization.JsonPropertyName("confirmed")]
        public bool Confirmed { get; set; }
    }
}