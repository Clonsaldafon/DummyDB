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

}
