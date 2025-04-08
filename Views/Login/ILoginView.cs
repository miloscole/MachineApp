namespace MachineApp.Views.Login
{
    public interface ILoginView
    {
        string Username { get; }
        string Password { get; }
        void ShowWelcome(string username, string role);
        void ShowError(string message);
    }
}
