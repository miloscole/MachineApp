using MachineApp.Models;

namespace MachineApp.Repositories
{
    public interface IUserRepo
    {
        User? GetUser(string username, string password);
    }
}
