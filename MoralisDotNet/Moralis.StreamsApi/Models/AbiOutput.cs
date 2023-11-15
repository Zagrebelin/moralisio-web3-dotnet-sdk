﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class AbiOutput
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; }

        [DataMember(Name = "components", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "components")]
        [System.Text.Json.Serialization.JsonPropertyName("components")]
        public object[] Components { get; set; }

        [DataMember(Name = "internalType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "internalType")]
        [System.Text.Json.Serialization.JsonPropertyName("internalType")]
        public string InternalType { get; set; }
    }
}
