using MachineApp.Repositories;
using MachineApp.Views.Login;

namespace MachineApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var repo = new UserRepository("server=localhost;user=root;password=root;database=machine_app;");
            Application.Run(new Login(repo));
        }
    }
}