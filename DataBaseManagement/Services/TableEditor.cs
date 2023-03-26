using System.Collections.Generic;

namespace DataBaseManagement
{
    public class TableEditor
    {
        public void AddRow(DatabaseContext context, Table table, List<string> values)
        {
            context.AddRow(table, values);
        }

        public void EditRow(DatabaseContext context, Row row, List<string> values)
        {
            context.EditRow(row, values);
        }

        public void DeleteRow(DatabaseContext context, Row row)
        {
            context.DeleteRow(row);
        }
    }
}
