namespace DataBaseManagement
{
    public class DataExporter
    {
        public void ExportToCSV(DatabaseContext context, Table table, string filePath)
        {
            context.ExportToCSV(table, filePath);
        }
    }
}
