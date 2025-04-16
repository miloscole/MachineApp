namespace MachineApp.Helpers
{
    public class Constants
    {
        // Actions info
        public const string OnlyAdminAllowed = "Only admin can perform this action!";
        public const string ConfirmDelete = "Are you sure you want to delete this machine?";
        public const string UpdateSuccess = "Successfully updated!";
        public const string CreateSuccess = "Successfully created!";
        public const string DeleteSuccess = "Successfully deleted!";
        public const string CreateFail = "Failed to create! ";
        public const string UpdateFail = "Failed to update! ";
        public const string DeleteFail = "Failed to delete! ";
        public const string LoadFail = "Failed to load! ";
        public const string NoneSelected = "No machine selected.";
        public const string EmptyLogInfoNew = "Please set at least one log to be able to Save.";
        public const string EmptyLogInfoEdit = "All dates are unset and log is removed from DB.";
        public const string WelcomeMsg = "Welcome to the MachineApp!";
        public const string InvalidCredentials = "Invalid username or password!";
        public const string UserInfoTemplate = "Logged in as: {0} ({1})";
        public const string EditMachineTitle = "Edit Machine";
        public const string EmptyTable = "Nothing to show! ";

        // Table headers
        public const string Id = "ID";
        public const string MachineName = "MACHINE NAME";
        public const string SerialNumber = "SERIAL NUMBER";
        public const string Specifications = "SPECIFICATIONS";
        public const string MachineType = "MACHINE TYPE";
        public const string StoredOn = "STORED ON";
    }
}
