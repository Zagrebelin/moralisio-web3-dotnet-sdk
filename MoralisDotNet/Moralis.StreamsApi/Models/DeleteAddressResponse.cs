using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class DeleteAddressResponse
    {
        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string Address { get; set; }

        [DataMember(Name = "streamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streamId", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("streamId")]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StreamId { get; set; }
    }
}
