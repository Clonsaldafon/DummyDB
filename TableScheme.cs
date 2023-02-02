using System.Collections.Generic;
using Newtonsoft.Json;

namespace DummyDB
{
    public class TableScheme
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }
        [JsonProperty(PropertyName = "columns")]
        public List<Column> Columns { get; private set; }

        public TableScheme(string name, List<Column> columns)
        {
            Name = name;
            Columns = columns;
        }
    }
}
