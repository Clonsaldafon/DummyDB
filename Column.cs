namespace DummyDB
{
    public enum ColumnType
    {
        Int, Float, String
    }

    public class Column
    {
        public string Name { get; private set; }

        public ColumnType DataType { get; private set; }

        public Column(string name)
        {
            Name = name;
        }
    }
}
