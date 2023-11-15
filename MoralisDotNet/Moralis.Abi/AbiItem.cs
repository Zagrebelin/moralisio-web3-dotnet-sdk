using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Moralis.Abi
{
	/// <summary>
	/// Defines an Abi Entry item.
	/// </summary>
	[DataContract]
	public class AbiItem
    {
		/// <summary>
		/// Indicates if event or function is anonymous.
		/// </summary>
		[DataMember(Name = "anonymous", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "anonymous", NullValueHandling = NullValueHandling.Ignore)] 
        [System.Text.Json.Serialization.JsonPropertyName("anonymous")]
        [System.Text.Json.Serialization.JsonIgnore]
		public bool Anonymous { get; set; }

		/// <summary>
		/// Name of the function or event.
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.Text.Json.Serialization.JsonIgnore]
		public string Name { get; set; }

		/// <summary>
		/// Type of function (view, etc.)
		/// </summary>
		[DataMember(Name = "stateMutability", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "stateMutability", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("stateMutability")]
        [System.Text.Json.Serialization.JsonIgnore]
		public string StateMutability { get; set; }

		/// <summary>
		/// Indicates if item is a function or event
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        [System.Text.Json.Serialization.JsonIgnore]
		public string Type { get; set; }

		/// <summary>
		/// A set of input parameters
		/// </summary>
		[DataMember(Name = "inputs", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "inputs", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [System.Text.Json.Serialization.JsonIgnore]
		public List<AbiParameter> Inputs { get; set; }

		/// <summary>
		/// A set of putput parameters.
		/// </summary>
		[DataMember(Name = "outputs", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "outputs", NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [System.Text.Json.Serialization.JsonIgnore]
		public List<AbiParameter> Outputs { get; set; }
	}
}
