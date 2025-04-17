using MachineApp.Models;
using MySql.Data.MySqlClient;

namespace MachineApp.Repositories.MachineLogRepository
{
    public class MachineLogRepo : BaseRepository, IMachineLogRepo
    {
        // SQL queries

        private const string GetByMachineIdQuery =
            "SELECT * FROM machine_logs WHERE machine_id = @machineId";

        private const string InsertQuery = @"
            INSERT INTO machine_logs 
                (machine_id, start_production_date, end_production_date, delivery_date) 
            VALUES 
                (@machineId, @start, @end, @delivery)";

        private const string UpdateQuery = @"
            UPDATE machine_logs 
            SET 
                start_production_date = @start,
                end_production_date = @end,
                delivery_date = @delivery
            WHERE machine_id = @machineId";

        private const string DeleteQuery = "DELETE FROM machine_logs WHERE id = @id";

        // Public methods

        public MachineLog? GetByMachineId(int machineId)
        {
            var parameters = new List<MySqlParameter> { new("@machineId", machineId) };
            using var reader = ExecuteReader(GetByMachineIdQuery, parameters);
            return reader.Read() ? ReadLog(reader) : null;
        }

        public void Insert(MachineLog log) =>
            ExecuteNonQuery(InsertQuery, CreateLogParameters(log));

        public void Update(MachineLog log) =>
            ExecuteNonQuery(UpdateQuery, CreateLogParameters(log));

        public void Delete(int id)
        {
            var parameters = new List<MySqlParameter> { new("@id", id) };
            ExecuteNonQuery(DeleteQuery, parameters);
        }

        // Helper methods

        private static List<MySqlParameter> CreateLogParameters(MachineLog log)
        {
            return
            [
                new MySqlParameter("@machineId", log.MachineId),
                new MySqlParameter("@start", log.StartProductionDate),
                new MySqlParameter("@end", log.EndProductionDate),
                new MySqlParameter("@delivery", log.DeliveryDate)
            ];
        }

        private static MachineLog ReadLog(MySqlDataReader reader)
        {
            return new MachineLog
            {
                Id = reader.GetInt32("id"),
                MachineId = reader.GetInt32("machine_id"),
                StartProductionDate = GetNullableDateTime(reader, "start_production_date"),
                EndProductionDate = GetNullableDateTime(reader, "end_production_date"),
                DeliveryDate = GetNullableDateTime(reader, "delivery_date")
            };
        }
    }
}
