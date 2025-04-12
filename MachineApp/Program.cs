using MachineApp.Helpers;
using MachineApp.Presenters;
using MachineApp.Repositories.MachineRepository;
using MachineApp.Repositories.UserRepository;
using MachineApp.Views.Login;
using MachineApp.Views.Machines.MachinesList;

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

            while (true)
            {
                var loginView = new Login();
                _ = new LoginPresenter(loginView, new UserRepo());
                loginView.ShowDialog();

                if (Session.CurrentUser == null)
                    break;

                var mainView = new MachinesList();
                _ = new MachinesListPresenter(mainView, new MachineRepo());
                Application.Run(mainView);

                if (!Session.IsLoggedIn)
                    continue;

                break;
            }
        }
    }
}