using MachineApp.Helpers;
using MachineApp.Models;

namespace MachineApp.Views.Machines.MachinesList
{
    public partial class MachinesList : Form, IMachineListView
    {
        public event EventHandler? LoadMachines;
        public event EventHandler AddMachineRequested;
        public event EventHandler EditMachineRequested;
        public event EventHandler DeleteMachineRequested;
        public event EventHandler LogoutRequested;

        public MachinesList()
        {
            InitializeComponent();
            AttachEvents();

            lblUserInfo.Text = $"Logged in as: {Session.CurrentUser?.Username} ({Session.CurrentUser?.RoleName})";
        }

        public void DisplayMachines(List<Machine> machines)
        {
            dgvMachines.DataSource = null;
            dgvMachines.DataSource = machines;
        }

        public void ShowError(string message)
        {
            lblGetMachinesError.Visible = true;
            lblGetMachinesError.Text = message;
        }

        void IMachineListView.Close()
        {
            this.Close();
        }

        public void HideAdminControls()
        {
            throw new NotImplementedException();
        }

        private void AttachEvents()
        {
            this.Load += (s, e) => LoadMachines?.Invoke(this, EventArgs.Empty);
            btnAdd.Click += (s, e) => AddMachineRequested.Invoke(this, EventArgs.Empty);
            btnEdit.Click += (s, e) => EditMachineRequested.Invoke(this, EventArgs.Empty);
            btnDelete.Click += (s, e) => DeleteMachineRequested.Invoke(this, EventArgs.Empty);
            btnLogout.Click += (s, e) => LogoutRequested.Invoke(this, EventArgs.Empty);
        }
    }
}
