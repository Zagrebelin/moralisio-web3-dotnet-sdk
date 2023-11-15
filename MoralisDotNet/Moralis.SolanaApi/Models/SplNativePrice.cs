﻿/**
 *           Module: SplNativePrice.cs
 *  Descriptiontion: Solana Native Price 
 *           Author: Moralis Web3 Technology AB, 559307-5988 - David B. Goodrich
 *  
 *  MIT License
 *  
 *  Copyright (c) 2022 Moralis Web3 Technology AB, 559307-5988
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy
 *  of this software and associated documentation files (the "Software"), to deal
 *  in the Software without restriction, including without limitation the rights
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *  copies of the Software, and to permit persons to whom the Software is
 *  furnished to do so, subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in all
 *  copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *  SOFTWARE.
 */
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Moralis.SolanaApi.Models
{
    [DataContract]
    public class SplNativePrice
    {
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

        [DataMember(Name = "decimals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "decimals")]
        [System.Text.Json.Serialization.JsonPropertyName("decimals")]
        public int Decimals { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "symbol")]
        [System.Text.Json.Serialization.JsonPropertyName("symbol")]
        public string Symbol { get; set; }
    }
}
