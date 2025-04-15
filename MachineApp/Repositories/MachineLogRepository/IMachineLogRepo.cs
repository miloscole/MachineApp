using MachineApp.Models;

namespace MachineApp.Repositories.MachineLogRepository
{
    public interface IMachineLogRepo
    {
        MachineLog? GetByMachineId(int machineId);
        void Insert(MachineLog log);
        void Update(MachineLog log);
        void Delete(int id);
    }
}
