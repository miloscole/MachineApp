namespace MachineApp.Helpers
{
    public class AppConfig
    {
        // TODO: Move connection string to .env file
        public static string ConnectionString { get; } = "server=localhost;user=ma_user;password=ma_pass;database=machine_app;";
    }
}
