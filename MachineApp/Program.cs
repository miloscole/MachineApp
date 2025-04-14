using MachineApp.Factory;
using MachineApp.Helpers;

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

            var factory = new ViewFactory();

            while (true)
            {
                var loginView = factory.CreateLoginView();
                loginView.ShowDialog();

                if (Session.CurrentUser == null)
                    break;

                var mainView = factory.CreateMachinesListView();
                Application.Run(mainView);

                if (!Session.IsLoggedIn)
                    continue;

                break;
            }
        }
    }
}