using MachineApp.Models;

namespace MachineApp.Repositories.MachineRepository
{
    public interface IMachineRepo
    {
        void Insert(Machine machine);
        void Update(Machine machine);
        void Delete(int id);
        List<Machine> GetAll();
        List<MachineType> GetAllMachineTypes();
    }
}
