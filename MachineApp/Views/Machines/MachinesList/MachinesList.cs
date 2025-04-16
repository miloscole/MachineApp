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
        }

        public void DisplayMachines(List<Machine> machines)
        {
            ResetGrid(dgvMachines);

            dgvMachines.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = Constants.Id,
                DataPropertyName = nameof(Machine.Id),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 70
            });

            dgvMachines.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = Constants.MachineName,
                DataPropertyName = nameof(Machine.Name),
            });

            dgvMachines.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = Constants.SerialNumber,
                DataPropertyName = nameof(Machine.SerialNumber),
            });

            dgvMachines.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = Constants.Specifications,
                DataPropertyName = nameof(Machine.Specifications),
            });

            dgvMachines.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = Constants.MachineType,
                DataPropertyName = nameof(Machine.MachineType),
            });

            dgvMachines.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = Constants.StoredOn,
                DataPropertyName = nameof(Machine.CreatedAt),
            });

            dgvMachines.DataSource = machines;
        }

        public void ShowErrorOnLoad(string message)
        {
            lblGetMachinesError.Visible = true;
            lblGetMachinesError.Text = message;
        }

        public void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfoMessageBox(string message)
        {
            MessageBox.Show(message, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool ShouldConfirmDeletion()
        {
            var result = MessageBox.Show(
                Constants.ConfirmDelete,
                String.Empty,
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

        public void SetUserInfo(string userInfoText)
        {
            lblUserInfo.Text = userInfoText;
        }

        public void CloseForm() => Close();

        public void HideAdminControls()
        {
            btnAdd.Hide();
            btnEdit.Hide();
            btnDelete.Hide();
            btnLogs.Hide();
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

        private static void ResetGrid(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();
        }
    }
}
