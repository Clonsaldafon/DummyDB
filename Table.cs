using System.Collections.Generic;

namespace DummyDB
{
    public class Table
    {
        public List<Row> Rows { get; private set; }
        public TableScheme TableScheme { get; private set; }

        public Table(List<Row> rows, TableScheme tableScheme)
        {
            Rows = rows;
            TableScheme = tableScheme;
        }
    }
}