using Newtonsoft.Json;

namespace DummyDB
{
    public enum ColumnType
    {
        Int, Float, String
    }

    public class Column
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }
        [JsonProperty(PropertyName = "type")]
        public ColumnType DataType { get; private set; }

        public Column(string name)
        {
            Name = name;
        }
    }
}
