using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class StreamBindingDto
    {
        [DataMember(Name = "webhookUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "webhookUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        public string WebHookUrl { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; }

        [DataMember(Name = "tag", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string Tag { get; set; }

        [DataMember(Name = "topic0", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "topic0", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("topic0")]
        [System.Text.Json.Serialization.JsonIgnore]
        public List<string> Topic { get; set; }

        [DataMember(Name = "allAddresses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "allAddresses")]
        [System.Text.Json.Serialization.JsonPropertyName("allAddresses")]
        public bool AllAddresses { get; set; }

        [DataMember(Name = "includeNativeTxs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "includeNativeTxs")]
        [System.Text.Json.Serialization.JsonPropertyName("includeNativeTxs")]
        public bool IncludeNativeTxs { get; set; }

        [DataMember(Name = "includeContractLogs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "includeContractLogs")]
        [System.Text.Json.Serialization.JsonPropertyName("includeContractLogs")]
        public bool IncludeContractLogs { get; set; }

        [DataMember(Name = "includeInternalTxs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "includeInternalTxs")]
        [System.Text.Json.Serialization.JsonPropertyName("includeInternalTxs")]
        public bool IncludeInternalTxs { get; set; }

        [DataMember(Name = "abi", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "abi", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("abi")]
        [System.Text.Json.Serialization.JsonIgnore]
        public List<AbiItem> Abi { get; set; }

        [DataMember(Name = "advancedOptions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "advancedOptions", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("advancedOptions")]
        [System.Text.Json.Serialization.JsonIgnore]
        public List<AdvancedOptions> AdvancedOptions { get; set; }

        [DataMember(Name = "chainIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "chainIds")]
        [System.Text.Json.Serialization.JsonPropertyName("chainIds")]
        public List<string> ChainIds { get; set; }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StreamId { get; set; }

        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        [System.Text.Json.Serialization.JsonIgnore]

        private string _streamStatus = null;

        [JsonIgnore]
        public StreamStatusTypes Status
        {
            get 
            {
                if (_streamStatus == null)
                {
                    return StreamStatusTypes.Error;
                }
                else
                {
                    return _streamStatus.ToStreamStatusTypes();
                }
            }
            set { _streamStatus = value.ToString(); }
        }

        [DataMember(Name = "statusMessage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statusMessage", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("statusMessage")]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StatusMessage { get; set; }
    }
}
