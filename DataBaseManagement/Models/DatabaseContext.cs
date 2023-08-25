using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Windows.Forms;
using System;

namespace DataBaseManagement
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Data Source=localhost;Initial Catalog=master;Integrated Security=True")
        {
        }

        public DbSet<Database> Databases { get; set; }

        public DbSet<Table> Tables { get; set; }

        public List<Row> GetRows(Table table)
        {
            return table.Rows.ToList();
        }

        public void ExportToCSV(Table table, string filePath)
        {
            List<Row> rows = new List<Row>(); // Pobierz wiersze dla wybranej tabeli (np. table.Rows.ToList())

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // write column headers
                    string headers = string.Join(";", table.Columns.Select(c => c.ColumnName));
                    sw.WriteLine(headers);

                    // write row data
                    foreach (Row row in rows)
                    {
                        List<string> rowData = new List<string>();

                        foreach (Cell cell in row.Cells)
                        {
                            rowData.Add(cell.Value);
                        }

                        sw.WriteLine(string.Join(";", rowData));
                    }
                }

                MessageBox.Show("Eksport do pliku CSV zakończony sukcesem.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas eksportu do pliku CSV: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public List<Row> FilterTable(Table table, string columnName, string filterValue)
        {
            List<Row> rows = table.Rows.ToList();
            List<Row> filteredRows = new List<Row>();

            foreach (Row row in rows)
            {
                string cellValue = row.Cells.Where(c => c.Column.ColumnName == columnName).FirstOrDefault()?.Value;

                if (cellValue != null && cellValue.Equals(filterValue))
                {
                    filteredRows.Add(row);
                }
            }

            return filteredRows;
        }

        public void AddRow(string databaseName, Table table, List<string> values)
        {
            string sql = $"USE {databaseName} INSERT INTO {table.Name} (";

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

        public void DeleteRow(Row row)
        {
            this.Entry(row).State = EntityState.Deleted;
            this.SaveChanges();
        }
        public void CreateTable(string databaseName, string tableName, List<string> columnNames, List<string> dataTypes, List<bool> IsNotNullConstraints, List<bool> IsPrimaryKeyColumns, List<bool> IsUniqueColumns)
        {
            string sql = $"USE {databaseName} CREATE TABLE {tableName} (";

            for (int i = 0; i < columnNames.Count; i++)
            {
                sql += $"{columnNames[i]} {dataTypes[i]}";

                if (IsNotNullConstraints[i])
                {
                    sql += " NOT NULL";
                }

                if (IsPrimaryKeyColumns[i])
                {
                    sql += " PRIMARY KEY";
                }

                if (IsUniqueColumns[i])
                {
                    sql += " UNIQUE";
                }

                if (i < columnNames.Count - 1)
                {
                    sql += ",";
                }
            }

            sql += ")";

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
                Name = tableName,
                Columns = new List<Column>()  // Tworzymy nową listę kolumn
            };

            for (int i = 0; i < columnNames.Count; i++)
            {
                Column column = new Column
                {
                    ColumnName = columnNames[i],
                    DataType = dataTypes[i],
                    IsNotNull = IsNotNullConstraints[i],
                    IsPrimaryKey = IsPrimaryKeyColumns[i],
                    IsUnique = IsUniqueColumns[i]
                };

                table.Columns.Add(column);  // Dodajemy nową kolumnę do listy kolumn tabeli
            }

            this.Tables.Add(table);
            this.SaveChanges();
        }

        public void EditTable(string databaseName, string tableName, List<string> columnNames, List<string> dataTypes, List<bool> IsNotNullConstraints, List<bool> IsPrimaryKeyColumns, List<bool> IsUniqueColumns)
        {
            using (SqlConnection connection = new SqlConnection($"Data Source=localhost;Initial Catalog={databaseName};Integrated Security=True"))
            {
                connection.Open();

                for (int i = 0; i < columnNames.Count; i++)
                {
                    string alterSql = $"USE {databaseName}; ALTER TABLE {tableName} ALTER COLUMN {columnNames[i]} {dataTypes[i]}";

                    if (IsNotNullConstraints[i])
                    {
                        alterSql += " NOT NULL";
                    }

                    if (IsPrimaryKeyColumns[i])
                    {
                        alterSql += $" ADD PRIMARY KEY {columnNames[i]}";
                    }

                    if (IsUniqueColumns[i])
                    {
                        alterSql += " UNIQUE";
                    }
                    
                    if (i < columnNames.Count - 1)
                    {
                        alterSql += ";";
                    }

                    using (SqlCommand command = new SqlCommand(alterSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                connection.Close();
            }
        }

    }
}
