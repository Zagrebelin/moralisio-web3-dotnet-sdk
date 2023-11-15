using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Moralis.Abi
{
    public class AbiParameter
    {
        /// <summary>
        /// True if the field is part of the log’s topics, false if it one of the log’s data segment.
        /// </summary>
        [DataMember(Name = "indexed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "indexed", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("indexed")]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool Indexed { get; set; }

        /// <summary>
        /// the canonical type of the parameter
        /// </summary>
        [DataMember(Name = "internalType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "internalType", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("internalType")]
        [System.Text.Json.Serialization.JsonIgnore]
        public string InternalType { get; set; }

        /// <summary>
        /// The parameter name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Name { get; set; }

        /// <summary>
        /// The canonical type of the parameter
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Type { get; set; }

        /// <summary>
        /// Used for tuple types 
        /// </summary>
        [DataMember(Name = "components", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "components", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("components")]
        [System.Text.Json.Serialization.JsonIgnore]
        public List<Component> Components { get; set; }

    }
}
