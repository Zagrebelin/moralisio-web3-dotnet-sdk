using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Moralis.Web3Api.Models
{
	[DataContract]
	public class NftCollection
	{
		/// <summary>
		/// The total number of matches for this query
		/// example: 2000
		/// </summary>
		[DataMember(Name = "total", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
		public int? Total { get; set; }

		/// <summary>
		/// The page of the current result
		/// example: 2
		/// </summary>
		[DataMember(Name = "page", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
		public int? Page { get; set; }

		/// <summary>
		/// The number of results per page
		/// example: 100
		/// </summary>
		[DataMember(Name = "page_size", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
		public int? PageSize { get; set; }

		/// <summary>
		/// </summary>
		[DataMember(Name = "result", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
		public List<Nft> Result { get; set; }


		/// <summary>
		/// Get the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NftCollection{");
			sb.Append("  Total ").Append(Total).Append("\n");
			sb.Append("  Page ").Append(Page).Append("\n");
			sb.Append("  PageSize ").Append(PageSize).Append("\n");
			sb.Append("  Result ").Append(Result).Append("\n");
			sb.Append("}");

			return sb.ToString();
		}

		/// <summary>
		/// Get the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}

	}
}