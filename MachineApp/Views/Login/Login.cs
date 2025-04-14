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

        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public void LoginSucceeded(User? user)
        {
            MessageBox.Show($"Welcome, {user?.Username}.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void ILogin.Close()
        {
            this.Close();
        }

        private void AttachEvents()
        {
            btnLogin.Click += (s, e) => LoginRequested?.Invoke();
            btnMinimize.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            btnClose.Click += (s, e) => this.Close();

            MouseEventHandler dragHandler = (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    WindowUtils.EnableDrag(this.Handle);
            };

            this.MouseDown += dragHandler;
            panLeftSide.MouseDown += dragHandler;
        }
    }
}
