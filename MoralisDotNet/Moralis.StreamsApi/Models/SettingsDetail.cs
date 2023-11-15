﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class SettingsDetail
    {
        private static List<string> regions = new List<string>(new string[] { "us-east-1", "us-west-2", "eu-central-1", "ap-southeast-1" });
        private string region = regions[0];

        [DataMember(Name = "region", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "region")]
        [System.Text.Json.Serialization.JsonPropertyName("region")]
        public string Region
        {
            get { return region; }
            set
            {
                if (!string.IsNullOrEmpty(value) && regions.Contains(value))
                {
                    region = value;
                }
                else
                {
                    throw new ArgumentException($"Valid values for Cluster are: [{string.Join(',', regions)}]");
                }
            }
        }
    }
}
