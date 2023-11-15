using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Moralis.Web3Api.Models
{
    public class VersionResponse
    {
        [DataMember(Name = "version", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
