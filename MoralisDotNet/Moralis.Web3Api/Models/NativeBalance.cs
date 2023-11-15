using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
namespace Moralis.Web3Api.Models
{
	[DataContract]
	public class NativeBalance : NativeTokenBalanceBase
	{
		public NativeBalance()
		{
			this.Decimals = 18;
		}

		/// <summary>
		/// The balance
		/// example: 1234567890
		/// </summary>
		[DataMember(Name = "balance", EmitDefaultValue = false)]
		[JsonProperty(PropertyName = "balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
		public string Balance { get; set; }
		
		/// <summary>
		/// Get the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NativeBalance{");
			sb.Append("  Balance ").Append(Balance).Append("\n");
			sb.Append("  NativeBalance ").Append(NativeTokenBalance).Append("\n");
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

		/// <summary>
		/// Used by base class to access the raw WEI string value.
		/// </summary>
		/// <returns></returns>
		protected override string RawBalance()
		{
			return Balance;
		}
	}
}