using MachineApp.Models;

namespace MachineApp.Repositories.UserRepository
{
    public interface IUserRepo
    {
        User? GetUser(string username, string password);
    }
}
