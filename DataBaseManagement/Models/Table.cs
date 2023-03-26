using System.Collections.Generic;
using System.Data.Common;

namespace DataBaseManagement
{
    public class Table
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Column> Columns { get; set; }
        public virtual ICollection<Row> Rows { get; set; }
    }
}
