using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class AbiItem
    {

        [DataMember(Name = "anonymous", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "anonymous")]
        [System.Text.Json.Serialization.JsonPropertyName("anonymous")]
        public bool Anonymous { get; set; }

        [DataMember(Name = "constant", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "constant")]
        [System.Text.Json.Serialization.JsonPropertyName("constant")]
        public bool Constant { get; set; }

        [DataMember(Name = "inputs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inputs")]
        [System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public List<AbiInput> Inputs { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [DataMember(Name = "outputs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outputs")]
        [System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public List<AbiOutput> Outputs { get; set; }

        [DataMember(Name = "payable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payable")]
        [System.Text.Json.Serialization.JsonPropertyName("payable")]
        public bool Payable { get; set; }

        [DataMember(Name = "stateMutability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stateMutability")]
        [System.Text.Json.Serialization.JsonPropertyName("stateMutability")]
        private string _stateMutability = StateMutabilityTypes.Pure.ToString();

        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        private string _abiType = AbiItemTypes.Event.ToString();

        [DataMember(Name = "gas", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gas")]
        [System.Text.Json.Serialization.JsonPropertyName("gas")]
        public BigInteger Gas { get; set; }

        [JsonIgnore]
        public StateMutabilityTypes StateMutability
        {
            get { return _stateMutability.ToStateMutabilityTypes(); }
            set { _stateMutability = value.ToString(); }
        }

        [JsonIgnore]
        public AbiItemTypes Type
        {
            get { return _abiType.ToAbiItemTypes(); }
            set { _abiType = value.ToString(); }
        }
    }
}
