using MachineApp.Helpers;
using MachineApp.Presenters;
using MachineApp.Repositories;

namespace MachineApp.Views.Login
{
    public partial class Login : Form, ILoginView
    {
        private LoginPresenter _presenter;

        public Login(IUserRepo repo)
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this, repo);

            AttachEvents();
        }

        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        public void ShowWelcome(string username, string role)
        {
            MessageBox.Show($"Welcome, {username} ({role})");
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AttachEvents()
        {
            btnLogin.Click += (s, e) => _presenter.Login();
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
