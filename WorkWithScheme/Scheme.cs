using System.Collections.Generic;
using Newtonsoft.Json;

namespace DummyDB.WorkWithScheme
{
    public class Scheme
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; }

        [JsonProperty(PropertyName = "columns")]
        public List<SchemeColumn> Columns { get; }
    }
}
