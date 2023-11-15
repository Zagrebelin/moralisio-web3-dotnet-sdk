using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Moralis.StreamsApi.Models
{
    public class Transaction
    {
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string Tag { get; set; }

        [DataMember(Name = "streamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streamId")]
        [System.Text.Json.Serialization.JsonPropertyName("streamId")]
        public string StreamId { get; set; }

        [DataMember(Name = "hash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hash")]
        [System.Text.Json.Serialization.JsonPropertyName("hash")]
        public string Hash { get; set; }

        [DataMember(Name = "gas", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gas")]
        [System.Text.Json.Serialization.JsonPropertyName("gas")]
        public string Gas { get; set; }

        [DataMember(Name = "gasPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gasPrice")]
        [System.Text.Json.Serialization.JsonPropertyName("gasPrice")]
        public string GasPrice { get; set; }

        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nonce")]
        [System.Text.Json.Serialization.JsonPropertyName("nonce")]
        public string Nonce { get; set; }

        [DataMember(Name = "input", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "input")]
        [System.Text.Json.Serialization.JsonPropertyName("input")]
        public string Input { get; set; }

        [DataMember(Name = "transactionIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactionIndex")]
        [System.Text.Json.Serialization.JsonPropertyName("transactionIndex")]
        public string TransactionIndex { get; set; }

        [DataMember(Name = "fromAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fromAddress")]
        [System.Text.Json.Serialization.JsonPropertyName("fromAddress")]
        public string FromAddress { get; set; }

        [DataMember(Name = "toAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "toAddress")]
        [System.Text.Json.Serialization.JsonPropertyName("toAddress")]
        public string ToAddress { get; set; }

        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; }

        [DataMember(Name = "v", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "v")]
        [System.Text.Json.Serialization.JsonPropertyName("v")]
        public string v { get; set; }

        [DataMember(Name = "r", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "r")]
        [System.Text.Json.Serialization.JsonPropertyName("r")]
        public string r { get; set; }

        [DataMember(Name = "s", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "s")]
        [System.Text.Json.Serialization.JsonPropertyName("s")]
        public string s { get; set; }

        [DataMember(Name = "receiptCumulativeGasUsed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "receiptCumulativeGasUsed")]
        [System.Text.Json.Serialization.JsonPropertyName("receiptCumulativeGasUsed")]
        public string ReceiptCumulativeGasUsed { get; set; }

        [DataMember(Name = "receiptGasUsed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "receiptGasUsed")]
        [System.Text.Json.Serialization.JsonPropertyName("receiptGasUsed")]
        public string ReceiptGasUsed { get; set; }

        [DataMember(Name = "receiptContractAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "receiptContractAddress")]
        [System.Text.Json.Serialization.JsonPropertyName("receiptContractAddress")]
        public string ReceiptContractAddress { get; set; }

        [DataMember(Name = "receiptRoot", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "receiptRoot")]
        [System.Text.Json.Serialization.JsonPropertyName("receiptRoot")]
        public string ReceiptRoot { get; set; }

        [DataMember(Name = "receiptStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "receiptStatus")]
        [System.Text.Json.Serialization.JsonPropertyName("receiptStatus")]
        public string ReceiptStatus { get; set; }
    }
}
