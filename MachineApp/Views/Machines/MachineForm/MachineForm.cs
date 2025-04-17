using MachineApp.Models;

namespace MachineApp.Views.Machines.MachineForm
{
    public partial class MachineForm : Form, IMachineForm
    {
        public event Action? SaveMachineRequested;

        public MachineForm()
        {
            InitializeComponent();
            AttachEvents();
        }

        //  Public Properties

        public List<MachineType> MachineTypes
        {
            set
            {
                ddTypes.DataSource = value;
                ddTypes.DisplayMember = nameof(MachineType.TypeName);
                ddTypes.ValueMember = nameof(MachineType.Id);
            }
        }

        //  Public Methods

        public void FillForm(Machine machine)
        {
            lbId.Text = machine.Id.ToString();
            txtName.Text = machine.Name;
            txtSerialNum.Text = machine.SerialNumber;
            txtSpec.Text = machine.Specifications;
            ddTypes.SelectedValue = machine.MachineTypeId;
        }

        public Machine GetMachineData()
        {
            return new Machine
            {
                Id = int.TryParse(lbId.Text, out var id) ? id : 0,
                Name = txtName.Text,
                SerialNumber = txtSerialNum.Text,
                Specifications = txtSpec.Text,
                MachineTypeId = (int)ddTypes.SelectedValue
            };
        }

        public void SetFormTitle(string title) => lbTitle.Text = title;

        public void ShowValidationErrors(List<string> errors)
        {
            MessageBox.Show(
                string.Join(Environment.NewLine, errors),
                string.Empty,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        public void ShowInfoMessageBox(string msg) =>
            MessageBox.Show(msg, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public void ShowErrorMessageBox(string msg) =>
            MessageBox.Show(msg, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
        public void SetDialogResult(DialogResult result) => DialogResult = result;

        public void CloseForm() => Close();

        //  Private Helpers

        private void AttachEvents()
        {
            btnSave.Click += (s, e) => SaveMachineRequested?.Invoke();
            btnCancel.Click += (s, e) => Close();
            btnClose.Click += (s, e) => Close();
        }
    }
}
