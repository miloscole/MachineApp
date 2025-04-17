using MachineApp.Helpers;
using MachineApp.Models;

namespace MachineApp.Views.Login
{
    public partial class Login : Form, ILogin
    {
        public event Action? LoginRequested;

        public Login()
        {
            InitializeComponent();
            AttachEvents();
        }

        //  Public Methods

        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public void LoginSucceeded(User? user) =>
            MessageBox.Show(Constants.WelcomeMsg, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public void ShowErrorMessageBox(string message) =>
            MessageBox.Show(message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public void CloseForm() => Close();

        //  Private Methods

        private void AttachEvents()
        {
            btnLogin.Click += (s, e) => LoginRequested?.Invoke();
            btnMinimize.Click += (s, e) => WindowState = FormWindowState.Minimized;
            btnClose.Click += (s, e) => Close();

            MouseEventHandler dragHandler = (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    WindowUtils.EnableDrag(Handle);
            };

            this.MouseDown += dragHandler;
            panLeftSide.MouseDown += dragHandler;
        }
    }
}
