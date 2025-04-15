using System.Data;
using MachineApp.Helpers;
using MachineApp.Models;
using MySql.Data.MySqlClient;

namespace MachineApp.Repositories.MachineLogRepository
{
    public class MachineLogRepo() : IMachineLogRepo
    {
        public MachineLog? GetByMachineId(int machineId)
        {
            using var connection = new MySqlConnection(AppConfig.ConnectionString);
            connection.Open();

            var command = new MySqlCommand("SELECT * FROM machine_logs WHERE machine_id = @machineId", connection);
            command.Parameters.AddWithValue("@machineId", machineId);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return ReadLog(reader);
            }

            return null;
        }

        public void Insert(MachineLog log)
        {
            using var connection = new MySqlConnection(AppConfig.ConnectionString);
            connection.Open();

            var command = new MySqlCommand(@"INSERT INTO machine_logs 
            (machine_id, start_production_date, end_production_date, delivery_date) 
            VALUES (@machineId, @start, @end, @delivery)", connection);

            command.Parameters.AddWithValue("@machineId", log.MachineId);
            command.Parameters.AddWithValue("@start", log.StartProductionDate);
            command.Parameters.AddWithValue("@end", log.EndProductionDate);
            command.Parameters.AddWithValue("@delivery", log.DeliveryDate);

            command.ExecuteNonQuery();
        }

        public void Update(MachineLog log)
        {
            using var connection = new MySqlConnection(AppConfig.ConnectionString);
            connection.Open();

            var command = new MySqlCommand(@"UPDATE machine_logs SET 
            start_production_date = @start,
            end_production_date = @end,
            delivery_date = @delivery
            WHERE machine_id = @machineId", connection);

            command.Parameters.AddWithValue("@start", log.StartProductionDate);
            command.Parameters.AddWithValue("@end", log.EndProductionDate);
            command.Parameters.AddWithValue("@delivery", log.DeliveryDate);
            command.Parameters.AddWithValue("@machineId", log.MachineId);

            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new MySqlConnection(AppConfig.ConnectionString);
            conn.Open();

            var query = "DELETE FROM machine_logs WHERE id = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        private static MachineLog ReadLog(MySqlDataReader reader)
        {
            return new MachineLog
            {
                Id = reader.GetInt32("id"),
                MachineId = reader.GetInt32("machine_id"),
                StartProductionDate = reader.IsDBNull("start_production_date") ? null : reader.GetDateTime("start_production_date"),
                EndProductionDate = reader.IsDBNull("end_production_date") ? null : reader.GetDateTime("end_production_date"),
                DeliveryDate = reader.IsDBNull("delivery_date") ? null : reader.GetDateTime("delivery_date")
            };
        }
    }


}
