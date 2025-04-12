using MachineApp.Helpers;
using MachineApp.Models;
using MySql.Data.MySqlClient;

namespace MachineApp.Repositories.MachineRepository
{
    public class MachineRepo() : IMachineRepo
    {
        private static void AddMachineParamettersWithValues(MySqlCommand cmd, Machine machine)
        {
            cmd.Parameters.AddWithValue("@name", machine.Name);
            cmd.Parameters.AddWithValue("@serial_number", machine.SerialNumber);
            cmd.Parameters.AddWithValue("@specifications", machine.Specifications);
            cmd.Parameters.AddWithValue("@machine_type_id", machine.MachineTypeId);
            cmd.Parameters.AddWithValue("@created_at", machine.CreatedAt);
            cmd.Parameters.AddWithValue("@updated_at", machine.UpdatedAt);
        }

        public void Create(Machine machine)
        {
            using var conn = new MySqlConnection(AppConfig.ConnectionString);
            conn.Open();
            var query = @"INSERT INTO machines 
                          VALUES (@name, @serial_number, @specifications, @machine_type_id, @created_at, @updated_at)";
            var cmd = new MySqlCommand(query, conn);
            AddMachineParamettersWithValues(cmd, machine);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = machine.Id;
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new MySqlConnection(AppConfig.ConnectionString);
            conn.Open();
            var query = "DELETE FROM machines WHERE id=@id";
            var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
        }

        public void Update(Machine machine)
        {
            using var conn = new MySqlConnection(AppConfig.ConnectionString);
            conn.Open();
            var query = @"UPDATE machines 
                          SET name=@name, serial_number=@serial_number, specifications=@specifications,
                          machine_type_id=@machine_type_id, created_at=@created_at, updated_at=@updated_at
                          WHERE id=@id";
            var cmd = new MySqlCommand(query, conn);
            AddMachineParamettersWithValues(cmd, machine);
            cmd.ExecuteNonQuery();
        }

        public List<Machine> GetAll()
        {
            var machines = new List<Machine>();
            using var conn = new MySqlConnection(AppConfig.ConnectionString);
            conn.Open();
            var query = "SELECT * FROM machines";
            var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                machines.Add(new Machine
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    SerialNumber = reader.GetString("serial_number"),
                    Specifications = reader.GetString("specifications"),
                    MachineTypeId = reader.GetInt32("machine_type_id"),
                    CreatedAt = reader.GetDateTime("created_at"),
                    UpdatedAt = reader.GetDateTime("updated_at")
                });
            }
            return machines;
        }

        public Machine? GetById(int id)
        {
            using var conn = new MySqlConnection(AppConfig.ConnectionString);
            conn.Open();
            var query = "SELECT id, name, serial_number FROM machines WHERE id = @id";
            var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Machine
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    SerialNumber = reader.GetString("serial_number")
                };
            }
            return null;
        }
    }
}
