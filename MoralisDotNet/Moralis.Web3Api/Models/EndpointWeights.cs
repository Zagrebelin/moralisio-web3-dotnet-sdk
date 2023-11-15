using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Moralis.Web3Api.Models
{
    public class EndpointWeights
    {
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endpoint")]
        [System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string Endpoint { get; set; }

        [DataMember(Name = "path", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string Path { get; set; }

        [DataMember(Name = "rateLimitWeight", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rateLimitWeight")]
        [System.Text.Json.Serialization.JsonPropertyName("rateLimitWeight")]
        public string RateLimitWeight { get; set; }

        [DataMember(Name = "price", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "price")]
        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public string Price { get; set; }
    }
}
