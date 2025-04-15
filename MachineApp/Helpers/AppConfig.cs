namespace MachineApp.Helpers
{
    public class AppConfig
    {
        // TODO: Move connection string to .env file
        public static string ConnectionString { get; } = "server=localhost;user=root;password=root;database=machine_app;";
    }
}
