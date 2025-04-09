using MachineApp.Models;
using MySql.Data.MySqlClient;

namespace MachineApp.Repositories
{
    public class UserRepository : IUserRepo
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public User? GetUser(string username, string password)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();
            var cmd = new MySqlCommand("SELECT * FROM users WHERE username=@u AND password=@p", conn);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", password);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    Username = reader.GetString("username"),
                    Role = reader.GetString("role")
                };
            }
            return null;
        }
    }
}
