using MachineApp.Models;
using MySql.Data.MySqlClient;

namespace MachineApp.Repositories.MachineRepository
{
    public class MachineRepo : BaseRepository, IMachineRepo
    {
        private const string InsertQuery = @"
            INSERT INTO machines 
                (name, serial_number, specifications, machine_type_id)
            VALUES 
                (@name, @serial_number, @specifications, @machine_type_id)";

        private const string UpdateQuery = @"
            UPDATE machines 
            SET
                name = @name, 
                serial_number = @serial_number, 
                specifications = @specifications,
                machine_type_id = @machine_type_id
            WHERE id = @id";

        private const string DeleteQuery = "DELETE FROM machines WHERE id = @id";

        private const string GetAllQuery = @"
            SELECT m.*, t.type_name 
            FROM machines m 
            LEFT JOIN machine_types t ON m.machine_type_id = t.id";

        private const string GetAllTypesQuery = "SELECT * FROM machine_types";

        public void Insert(Machine machine)
        {
            ExecuteNonQuery(InsertQuery, CreateMachineParameters(machine));
        }

        public void Update(Machine machine)
        {
            var parameters = CreateMachineParameters(machine);
            parameters.Add(new MySqlParameter("@id", machine.Id));
            ExecuteNonQuery(UpdateQuery, parameters);
        }

        public void Delete(int id)
        {
            var parameters = new List<MySqlParameter> { new("@id", id) };
            ExecuteNonQuery(DeleteQuery, parameters);
        }

        public List<Machine> GetAll()
        {
            using var reader = ExecuteReader(GetAllQuery);

            var machines = new List<Machine>();
            while (reader.Read())
            {
                machines.Add(ReadMachine(reader));
            }

            return machines;
        }

        public List<MachineType> GetAllMachineTypes()
        {
            using var reader = ExecuteReader(GetAllTypesQuery);

            var types = new List<MachineType>();
            while (reader.Read())
            {
                types.Add(ReadMachineType(reader));
            }

            return types;
        }

        // Helper methods

        private static List<MySqlParameter> CreateMachineParameters(Machine machine)
        {
            return new List<MySqlParameter>
            {
                new("@name", machine.Name),
                new("@serial_number", machine.SerialNumber),
                new("@specifications", machine.Specifications),
                new("@machine_type_id", machine.MachineTypeId)
            };
        }

        private static Machine ReadMachine(MySqlDataReader reader)
        {
            return new Machine
            {
                Id = reader.GetInt32("id"),
                Name = reader.GetString("name"),
                SerialNumber = reader.GetString("serial_number"),
                Specifications = GetNullableString(reader, "specifications"),
                MachineTypeId = GetNullableInt(reader, "machine_type_id"),
                MachineType = GetNullableString(reader, "type_name"),
                CreatedAt = reader.GetDateTime("created_at"),
                UpdatedAt = reader.GetDateTime("updated_at")
            };
        }

        private static MachineType ReadMachineType(MySqlDataReader reader)
        {
            return new MachineType
            {
                Id = reader.GetInt32("id"),
                TypeName = reader.GetString("type_name"),
                Description = GetNullableString(reader, "description")
            };
        }
    }
}
