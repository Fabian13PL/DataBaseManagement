using System.Collections.Generic;

namespace DataBaseManagement
{
    public class TableFilter
    {
        public List<Row> FilterTable(DatabaseContext context, Table table, string columnName, string filterValue)
        {
            return context.FilterTable(table, columnName, filterValue);
        }
    }
}
