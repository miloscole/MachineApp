using MachineApp.Models;

namespace MachineApp.Helpers
{
    public static class Session
    {
        public static User? CurrentUser { get; private set; }
        public static void SetUpSession(User? user) => CurrentUser = user;
        public static void ClearSession() => CurrentUser = null;
        public static bool IsAdmin => CurrentUser?.RoleName == "admin";
        public static bool IsLoggedIn => CurrentUser != null;
    }
}

