using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class StatsDetail
    {
        [DataMember(Name = "totalWebhooksDelivered", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalWebhooksDelivered")]
        [System.Text.Json.Serialization.JsonPropertyName("totalWebhooksDelivered")]
        public BigInteger TotalWebhooksDelivered { get; set; }

        [DataMember(Name = "totalWebhooksFailed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalWebhooksDelivered")]
        [System.Text.Json.Serialization.JsonPropertyName("totalWebhooksDelivered")]
        public BigInteger TotalWebhooksFailed { get; set; }

        [DataMember(Name = "totalLogsProcessed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalLogsProcessed")]
        [System.Text.Json.Serialization.JsonPropertyName("totalLogsProcessed")]
        public BigInteger TotalLogsProcessed { get; set; }

        [DataMember(Name = "totalTxsProcessed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalTxsProcessed")]
        [System.Text.Json.Serialization.JsonPropertyName("totalTxsProcessed")]
        public BigInteger TotalTransactionsProcessed { get; set; }

        [DataMember(Name = "totalTxsInternalProcessed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalTxsInternalProcessed")]
        [System.Text.Json.Serialization.JsonPropertyName("totalTxsInternalProcessed")]
        public BigInteger TotalTransactionsInternalProcessed { get; set; }
    }
}
