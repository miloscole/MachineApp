using MachineApp.Models;
using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;


namespace MachineApp.Repositories.UserRepository
{
    public class UserRepo : BaseRepository, IUserRepo
    {
        // SQL queries

        private const string GetUserQuery = @"
            SELECT u.id, u.username, u.password, r.name 
            FROM users u 
            JOIN roles r ON u.role_id = r.id 
            WHERE u.username = @username";

        // Public methods

        public User? GetUser(string username, string password)
        {
            var parameters = new List<MySqlParameter> { new("@username", username) };
            using var reader = ExecuteReader(GetUserQuery, parameters);

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