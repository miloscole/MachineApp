using MachineApp.Models;

namespace MachineApp.Views.Login
{
    public interface ILogin
    {
        event Action? LoginRequested;
        string Username { get; }
        string Password { get; }
        void LoginSucceeded(User? user);
        void ShowErrorMessageBox(string message);
        void CloseForm();
    }
}
