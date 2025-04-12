using MachineApp.Models;

namespace MachineApp.Views.Login
{
    public interface ILoginView
    {
        event EventHandler LoginAttempted;
        string Username { get; }
        string Password { get; }
        void LoginSucceeded(User? user);
        void ShowError(string message);
        void Close();
    }
}
