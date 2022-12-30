using Newtonsoft.Json;

namespace DummyDB.WorkWithScheme
{
    public class SchemeColumn
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; }

        [JsonProperty(PropertyName = "referencedTable")]
        public string ReferencedTable { get; }

        [JsonProperty(PropertyName = "isPrimary")]
        public bool IsPrimary { get; }
    }
}
