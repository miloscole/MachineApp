
using MachineApp.Models;

namespace MachineApp.Views.Machines.MachineLogForm
{
    public partial class MachineLogForm : Form, IMachineLogForm
    {
        public event Action? SaveLogRequested;

        public MachineLogForm()
        {
            InitializeComponent();
            AttachEvents();
        }

        //  Public Methods

        public void FillForm(MachineLog log)
        {
            lbId.Text = log.Id.ToString();
            InitilizeDateFields(log.StartProductionDate, log.EndProductionDate, log.DeliveryDate);
        }

        public MachineLog GetFormData()
        {
            return new MachineLog
            {
                Id = int.TryParse(lbId.Text, out var id) ? id : 0,
                MachineId = int.Parse(lbMachineId.Text),
                StartProductionDate = dtStartProduction.Checked ? dtStartProduction.Value : null,
                EndProductionDate = dtEndProduction.Checked ? dtEndProduction.Value : null,
                DeliveryDate = dtDeliveryDate.Checked ? dtDeliveryDate.Value : null
            };
        }

        public void SetMachineId(int id) => lbMachineId.Text = id.ToString();

        public void ShowInfoMessageBox(string msg) =>
            MessageBox.Show(msg, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public void ShowErrorMessageBox(string msg) =>
            MessageBox.Show(msg, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public void HideAdminControls()
        {
            btnSave.Hide();

            // Disable Date fields and hide Cancel button as well for better UI
            DisableDateFileds();
            btnCancel.Hide();
        }

        public void CloseForm() => Close();

        //  Private Methods

        private void AttachEvents()
        {
            btnSave.Click += (s, e) => SaveLogRequested?.Invoke();
            btnCancel.Click += (s, e) => Close();
            btnClose.Click += (s, e) => Close();
        }

        //  Private Helpers

        private void InitilizeDateFields(DateTime? sDate, DateTime? eDate, DateTime? dDate)
        {
            dtStartProduction.Checked = sDate.HasValue;
            if (sDate.HasValue) dtStartProduction.Value = sDate.Value;

            dtEndProduction.Checked = eDate.HasValue;
            if (eDate.HasValue) dtEndProduction.Value = eDate.Value;

            dtDeliveryDate.Checked = dDate.HasValue;
            if (dDate.HasValue) dtDeliveryDate.Value = dDate.Value;
        }

        private void DisableDateFileds()
        {
            dtStartProduction.Enabled = false;
            dtEndProduction.Enabled = false;
            dtDeliveryDate.Enabled = false;
        }
    }
}
