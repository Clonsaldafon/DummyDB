using System.Collections.Generic;

namespace DummyDB
{
    public class Row
    {
        public Dictionary<Column, object> Data { get; private set; }

        public Row(Dictionary<Column, object> data)
        {
            Data = data;
        }
    }
}
