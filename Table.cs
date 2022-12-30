using System.Collections.Generic;

namespace DummyDB
{
    public class TableScheme
    {
        public string Name { get; }
        public List<Column> Columns { get; }

        public TableScheme(string name, List<Column> columns)
        {
            Name = name;
            Columns = columns;
        }
    }

    public class Table
    {
        public List<Row> Rows { get; }
        private TableScheme TableScheme { get; }

        public Table(List<Row> rows, TableScheme tableScheme)
        {
            Rows = rows;
            TableScheme = tableScheme;
        }
    }

    public class Row
    {
        public Dictionary<Column, object> Data { get; }

        public Row(Dictionary<Column, object> data)
        {
            Data = data;
        }
    }

    public class Column
    {
        public string Name { get; }

        public ColumnType DataType { get; }

        public Column(string name)
        {
            Name = name;
        }
    }

    public enum ColumnType
    {
        Int, Float, String
    }

}
