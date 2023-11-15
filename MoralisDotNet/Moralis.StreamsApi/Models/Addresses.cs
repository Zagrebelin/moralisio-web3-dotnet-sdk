using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class Addresses
    {
        /// <summary>
        /// The address added to the stream
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string Address { get; set; }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Id { get; set; }
    }
}
