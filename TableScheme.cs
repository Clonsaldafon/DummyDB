using System.Collections.Generic;

namespace DummyDB
{
    public class TableScheme
    {
        public string Name { get; private set; }
        public List<Column> Columns { get; private set; }

        public TableScheme(string name, List<Column> columns)
        {
            Name = name;
            Columns = columns;
        }
    }
}
