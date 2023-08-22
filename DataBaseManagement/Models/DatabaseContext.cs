using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace DataBaseManagement
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection")
        {
        }

        public DbSet<Database> Databases { get; set; }

        public DbSet<Table> Tables { get; set; }

        public List<Row> GetRows(Table table)
        {
            return this.Tables.Find(table.Id).Rows.ToList();
        }

        public void ExportToCSV(Table table, string filePath)
        {
            List<Row> rows = this.GetRows(table);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // write column headers
                string headers = string.Join(",", table.Columns.Select(c => c.Name));
                sw.WriteLine(headers);

                // write row data
                foreach (Row row in rows)
                {
                    List<string> rowData = new List<string>();

                    foreach (Cell cell in row.Cells)
                    {
                        rowData.Add(cell.Value);
                    }

                    sw.WriteLine(string.Join(",", rowData));
                }
            }
        }

        public List<Row> FilterTable(Table table, string columnName, string filterValue)
        {
            List<Row> rows = this.Tables.Find(table.Id).Rows.ToList();
            List<Row> filteredRows = new List<Row>();

            foreach (Row row in rows)
            {
                string cellValue = row.Cells.Where(c => c.Column.Name == columnName).FirstOrDefault()?.Value;

                if (cellValue != null && cellValue.Equals(filterValue))
                {
                    filteredRows.Add(row);
                }
            }

            return filteredRows;
        }

        public void AddRow(Table table, List<string> values)
        {
            Row row = new Row { Cells = new List<Cell>() };

            for (int i = 0; i < values.Count; i++)
            {
                Cell cell = new Cell
                {
                    Column = table.Columns.ToList()[i],
                    Value = values[i]
                };

                row.Cells.Add(cell);
            }

            table.Rows.Add(row);
            this.SaveChanges();
        }

        public void EditRow(Row row, List<string> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                row.Cells.ToList()[i].Value = values[i];
            }

            this.SaveChanges();
        }

        public void DeleteRow(Row row)
        {
            this.Entry(row).State = EntityState.Deleted;
            this.SaveChanges();
        }
        public void CreateTable(string tableName, List<string> columnNames, List<string> dataTypes, string databaseName)
        {
            string sql = $"USE {databaseName} CREATE TABLE {tableName} (";

            for (int i = 0; i < columnNames.Count; i++)
            {
                sql += $"{columnNames[i]} {dataTypes[i]}";

                if (i < columnNames.Count - 1)
                {
                    sql += ",";
                }
            }

            sql += ")";

            //this.Database.ExecuteSqlCommand(sql);
            using (SqlConnection connection = new SqlConnection($"Data Source=localhost;Initial Catalog=master;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

            Table table = new Table
            {
                Name = tableName
            };

            this.Tables.Add(table);
            this.SaveChanges();
        }
        public void EditTable(Table table, List<string> columnNames, List<string> dataTypes)
        {
            string sql = $"ALTER TABLE {table.Name} ";

            for (int i = 0; i < columnNames.Count; i++)
            {
                sql += $"ALTER COLUMN {columnNames[i]} {dataTypes[i]}";

                if (i < columnNames.Count - 1)
                {
                    sql += ",";
                }
            }

            this.Database.ExecuteSqlCommand(sql);
        }
    }
}
