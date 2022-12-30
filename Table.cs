using System.Collections.Generic;

namespace DummyDB
{
    public class Table
    {
        public List<Row> Rows { get; }
        private TableScheme TableScheme { get; }
}

    public class Row
    {
        public Dictionary<Column, object> Data { get; }
    }

    public class Column
    {
        public string Name { get; }

        public ColumnType DataType { get; }
    }

    public enum ColumnType
    {
        Int, Float, String
    }

}
