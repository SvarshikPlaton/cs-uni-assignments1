using System.Text.Json.Serialization;

namespace lb7App01
{
    class Currency
    {
        [JsonPropertyName("r030")]
        public int Index { get; set; }

        [JsonPropertyName("txt")]
        public string Name { get; set; }
        [JsonPropertyName("rate")]
        public double Rate { get; set; }
        [JsonPropertyName("exchangedate")]
        public string Date { get; set; }
    }
}
