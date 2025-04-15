using System.Data;
using MachineApp.Helpers;
using MySql.Data.MySqlClient;

namespace MachineApp.Repositories
{
    public abstract class BaseRepository
    {
        protected void ExecuteNonQuery(string query, List<MySqlParameter> parameters)
        {
            using var connection = CreateConnection();
            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddRange(parameters.ToArray());
            command.ExecuteNonQuery();
        }

        protected MySqlDataReader ExecuteReader(string query, List<MySqlParameter>? parameters = null)
        {
            var connection = CreateConnection();
            var command = new MySqlCommand(query, connection);

            if (parameters != null)
                command.Parameters.AddRange(parameters.ToArray());

            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        protected static DateTime? GetNullableDateTime(MySqlDataReader reader, string column)
        {
            return reader.IsDBNull(column) ? null : reader.GetDateTime(column);
        }

        protected static Int32? GetNullableInt(MySqlDataReader reader, string column)
        {
            return reader.IsDBNull(column) ? null : reader.GetInt32(column);
        }

        protected static String? GetNullableString(MySqlDataReader reader, string column)
        {
            return reader.IsDBNull(column) ? null : reader.GetString(column);
        }

        private static MySqlConnection CreateConnection()
        {
            var connection = new MySqlConnection(AppConfig.ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
