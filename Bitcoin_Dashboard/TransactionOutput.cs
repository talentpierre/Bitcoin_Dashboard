using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bitcoin_Dashboard
{
    class TransactionOutput
    {
        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("ver")]
        public int Ver { get; set; }

        [JsonPropertyName("vin_sz")]
        public int VinSz { get; set; }

        [JsonPropertyName("vout_sz")]
        public int VoutSz { get; set; }

        [JsonPropertyName("lock_time")]
        public int LockTime { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("in")]
        public List<In> In { get; set; }

        [JsonPropertyName("out")]
        public List<Out> Out { get; set; }
    }

    public class PrevOut
    {
        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("n")]
        public int N { get; set; }
    }

    public class In
    {
        [JsonPropertyName("prev_out")]
        public PrevOut PrevOut { get; set; }

        [JsonPropertyName("scriptSig")]
        public string ScriptSig { get; set; }

        [JsonPropertyName("witness")]
        public string Witness { get; set; }

        [JsonPropertyName("sequence")]
        public long Sequence { get; set; }
    }

    public class Out
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("scriptPubKey")]
        public string ScriptPubKey { get; set; }
    }
}
