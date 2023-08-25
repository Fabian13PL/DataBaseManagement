namespace DataBaseManagement
{
    public class Column
    {
        public int Id { get; set; }
        public string TableName { get; internal set; }
        public string ColumnName { get; internal set; }
        public string DataType { get; internal set; }
        public bool IsNotNull { get; internal set; }
        public bool IsPrimaryKey { get; internal set; }
        public bool IsUnique { get; internal set; }
    }
}
