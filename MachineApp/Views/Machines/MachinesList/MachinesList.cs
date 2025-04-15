using MachineApp.Helpers;
using MachineApp.Models;

namespace MachineApp.Views.Machines.MachinesList
{
    public partial class MachinesList : Form, IMachineList
    {
        public event Action? LoadMachines;
        public event Action? AddMachineRequested;
        public event Action<Machine>? EditMachineRequested;
        public event Action? DeleteMachineRequested;
        public event Action? LogoutRequested;
        public event Action<int>? MachineLogRequested;

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

        public void ShowErrorOnLoad(string message)
        {
            lblGetMachinesError.Visible = true;
            lblGetMachinesError.Text = message;
        }

        public void ShowErrorOnDelete(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool ShouldConfirmDeletion()
        {
            var result = MessageBox.Show(
                "Are you Sure?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            return result == DialogResult.Yes;
        }

        public Machine? SelectedMachine
        {
            get
            {
                if (dgvMachines.SelectedRows.Count == 0)
                    return null;

                return dgvMachines.SelectedRows[0].DataBoundItem as Machine;
            }
        }

        public void CloseForm() => Close();

        public void HideAdminControls()
        {
            throw new NotImplementedException();
        }

        private void AttachEvents()
        {
            Load += (s, e) => LoadMachines?.Invoke();
            btnAdd.Click += (s, e) => AddMachineRequested?.Invoke();
            btnEdit.Click += (s, e) =>
            {
                if (SelectedMachine != null)
                    EditMachineRequested?.Invoke(SelectedMachine);
            };
            btnDelete.Click += (s, e) => DeleteMachineRequested?.Invoke();
            btnLogout.Click += (s, e) => LogoutRequested?.Invoke();
            btnLogs.Click += (s, e) =>
            {
                if (SelectedMachine != null)
                    MachineLogRequested?.Invoke(SelectedMachine.Id);
            };
        }
    }
}
