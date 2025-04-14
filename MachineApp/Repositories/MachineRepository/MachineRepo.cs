using MachineApp.Helpers;
using MachineApp.Models;
using MySql.Data.MySqlClient;

namespace MachineApp.Repositories.MachineRepository
{
    public class MachineRepo() : IMachineRepo
    {
        public void Insert(Machine machine)
        {
            using var conn = new MySqlConnection(AppConfig.ConnectionString);
            conn.Open();

            var query = @"INSERT INTO machines 
                            (name, serial_number, specifications, machine_type_id)
                          VALUES 
                            (@name, @serial_number, @specifications, @machine_type_id)";
            using var cmd = new MySqlCommand(query, conn);
            AddMachineParameters(cmd, machine);
            cmd.ExecuteNonQuery();
        }

        public void Update(Machine machine)
        {
            using var conn = new MySqlConnection(AppConfig.ConnectionString);
            conn.Open();

            var query = @"UPDATE machines 
                          SET
                            name = @name, 
                            serial_number = @serial_number, 
                            specifications = @specifications,
                            machine_type_id = @machine_type_id
                          WHERE id = @id";
            using var cmd = new MySqlCommand(query, conn);
            AddMachineParameters(cmd, machine);
            cmd.Parameters.AddWithValue("@id", machine.Id);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new MySqlConnection(AppConfig.ConnectionString);
            conn.Open();

            var query = "DELETE FROM machines WHERE id = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public List<Machine> GetAll()
        {
            var machines = new List<Machine>();
            using var conn = new MySqlConnection(AppConfig.ConnectionString);
            conn.Open();

            var query = @"SELECT m.*, t.type_name 
                          FROM machines m 
                          JOIN machine_types t ON m.machine_type_id = t.id";
            using var cmd = new MySqlCommand(query, conn);
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
                    MachineType = reader.GetString("type_name"),
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

            var query = @"SELECT m.*, t.type_name 
                          FROM machines m 
                          JOIN machine_types t ON m.machine_type_id = t.id 
                          WHERE m.id = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Machine
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    SerialNumber = reader.GetString("serial_number"),
                    Specifications = reader.GetString("specifications"),
                    MachineTypeId = reader.GetInt32("machine_type_id"),
                    MachineType = reader.GetString("type_name"),
                    CreatedAt = reader.GetDateTime("created_at"),
                    UpdatedAt = reader.GetDateTime("updated_at")
                };
            }

            return null;
        }

        public List<MachineType> GetAllMachineTypes()
        {
            var types = new List<MachineType>();
            using var conn = new MySqlConnection(AppConfig.ConnectionString);
            conn.Open();

            var query = "SELECT * FROM machine_types";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                types.Add(new MachineType
                {
                    Id = reader.GetInt32("id"),
                    TypeName = reader.GetString("type_name"),
                    Description = reader.GetString("description")
                });
            }

            return types;
        }

        private static void AddMachineParameters(MySqlCommand cmd, Machine machine)
        {
            cmd.Parameters.AddWithValue("@name", machine.Name);
            cmd.Parameters.AddWithValue("@serial_number", machine.SerialNumber);
            cmd.Parameters.AddWithValue("@specifications", machine.Specifications);
            cmd.Parameters.AddWithValue("@machine_type_id", machine.MachineTypeId);
        }
    }

}
