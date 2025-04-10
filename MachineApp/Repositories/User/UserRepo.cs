using MachineApp.Models;
using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;


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
            var query = "SELECT u.id, u.username, u.password, r.name FROM users u JOIN roles r ON u.role_id = r.id WHERE u.username = @u";
            var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u", username);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var hashedPassword = reader.GetString("password");

                if (BC.Verify(password, hashedPassword))
                {
                    return new User
                    {
                        Id = reader.GetInt32("id"),
                        Username = reader.GetString("username"),
                        RoleName = reader.GetString("name")
                    };
                }
            }
            return null;
        }
    }
}