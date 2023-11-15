using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class HistoryDetail
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string HistoryId { get; set; }

        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "date")]
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public DateTime HistoryDate { get; set; }

        [DataMember(Name = "payload", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payload")]
        [System.Text.Json.Serialization.JsonPropertyName("payload")]
        public Webhook Payload { get; set; }

        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorMessage")]
        [System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }

        [DataMember(Name = "webhookUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "webhookUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        public string WebhookUrl { get; set; }
    }
}
