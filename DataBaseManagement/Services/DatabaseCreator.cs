using DataBaseManagement;
using System.Data.SqlClient;

namespace DataBaseManagement
{
    public class DatabaseCreator
    {
        public void CreateDatabase(string name, string description, string serverName)
        {
            string connectionString = $"Data Source={serverName};Initial Catalog=master;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = $"CREATE DATABASE [{name}]";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            string databaseConnectionString = $"Data Source={serverName};Initial Catalog={name};Integrated Security=True";

            Database database = new Database
            {
                Name = name,
                Description = description,
                ConnectionString = databaseConnectionString
            };

            using (DatabaseContext context = new DatabaseContext())
            {
                context.Databases.Add(database);
                context.SaveChanges();
            }
        }
    }
}
