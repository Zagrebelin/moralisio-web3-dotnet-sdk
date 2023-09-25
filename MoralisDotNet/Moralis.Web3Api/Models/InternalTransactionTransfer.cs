using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Moralis.Web3Api.Models
{
    public class InternalTransactionTransfer
    {
        /// <summary>
        /// The hash of the transaction
        /// example: 0x057Ec652A4F150f7FF94f089A38008f49a0DF88e
        /// </summary>
        [DataMember(Name = "transaction_hash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transaction_hash")]
        public string TransactionHash { get; set; }
        /// <summary>
        /// The block number
        /// example: 12526958
        /// </summary>
        [DataMember(Name = "block_number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "block_number")]
        public string BlockNumber { get; set; }
        /// <summary>
        /// The block hash
        /// example: 0x0372c302e3c52e8f2e15d155e2c545e6d802e479236564af052759253b20fd86
        /// </summary>
        [DataMember(Name = "block_hash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "block_hash")]
        public string BlockHash { get; set; }
        /// <summary>
        /// The sender
        /// example: 0xd4a3BebD824189481FC45363602b83C9c7e9cbDf
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }

        /// <summary>
        /// The recipient
        /// example: 0xa71db868318f0a0bae9411347cd4a6fa23d8d4ef
        /// </summary>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }

        /// <summary>
        /// The value that was transfered (in wei)
        /// example: 650000000000000000
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// The gas of the transaction
        /// example: 6721975
        /// </summary>
        [DataMember(Name = "gas", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gas")]
        public string Gas { get; set; }

        /// <summary>
        /// The gas price
        /// example: 20000000000
        /// </summary>
        [DataMember(Name = "gas_used", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gas_used")]
        public string GasUsed { get; set; }
        /// <summary>
        /// The input
        /// </summary>
        [DataMember(Name = "input", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "input")]
        public string Input { get; set; }

        /// <summary>
        /// The input
        /// </summary>
        [DataMember(Name = "output", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "output")]
        public string Output { get; set; }


        // "transaction_hash": "0xe0136740445f01e50d727b3bd14737b1f6d3363b39bbe9c6309b3db9e1e06bcd",
        // "block_number": 17894806,
        // "block_hash": "0x64a34351677e9de16247fa263ba5037fd3251c1b90931d43081c0580a3251143",
        // "type": "CALL",
        // "from": "0xd152f549545093347a162dce210e7293f1452150",
        // "to": "0xcca02de5372cb0caac425543487789eef5d17fb5",
        // "value": "80000000000000000",
        // "gas": "2300",
        // "gas_used": "0",
        // "input": "0x",
        // "output": ""
    }
}