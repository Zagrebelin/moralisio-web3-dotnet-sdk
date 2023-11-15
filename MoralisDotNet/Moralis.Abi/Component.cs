using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Moralis.Abi
{
    /// <summary>
    /// Defines a component type used for tuple types.
    /// </summary>
    public class Component
    {
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
